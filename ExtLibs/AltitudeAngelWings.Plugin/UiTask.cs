﻿using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AltitudeAngelWings.Plugin.Properties;
using MissionPlanner;
using MissionPlanner.Utilities;

namespace AltitudeAngelWings.Plugin
{
    public static class UiTask
    {
        private static readonly TimeSpan TaskCheckInterval = TimeSpan.FromMilliseconds(100);
        private static readonly TimeSpan WaitToShowTime = TimeSpan.FromMilliseconds(200);


        public static T ShowWaitPanel<T>(Control parentControl, Func<CancellationToken, Task<T>> runTask, string description, bool waitToShow = true)
        {
            var cts = new CancellationTokenSource();
            WaitPanel panel = null;
            var start = DateTimeOffset.UtcNow;
            var waitTime = waitToShow ? WaitToShowTime : TimeSpan.Zero;
            var task = runTask(cts.Token);
            try
            {
                do
                {
                    if (panel == null && DateTimeOffset.UtcNow.Subtract(start) >= waitTime)
                    {
                        panel = ShowWaitPanel(parentControl, description, cts);
                    }

                    panel?.BringToFront();
                    Application.DoEvents();
                } while (!task.Wait(TaskCheckInterval));
                return task.GetAwaiter().GetResult();
            }
            catch (TaskCanceledException)
            {
                // This is OK
                return default;
            }
            catch (AggregateException ae) when (ae.InnerExceptions.OfType<TaskCanceledException>().Any())
            {
                // This is OK
                return default;
            }
            catch (Exception e)
            {
                if (panel == null)
                {
                    panel = ShowWaitPanel(parentControl, description, cts);
                }
                panel.Exception = e;
                panel.BringToFront();
                panel.OkClick += (sender, args) =>
                {
                    HideWaitPanel(parentControl, panel);
                };
            }
            finally
            {
                if (panel != null && panel.Exception == null)
                {
                    HideWaitPanel(parentControl, panel);
                }
            }

            return default;
        }

        private static WaitPanel ShowWaitPanel(Control parentControl, string description, CancellationTokenSource cts)
        {
            parentControl.SuspendLayout();
            var panel = new WaitPanel
            {
                Size = parentControl.ClientSize,
                Operation = description
            };
            parentControl.Controls.Add(panel);
            panel.BringToFront();
            parentControl.UseWaitCursor = true;
            panel.CancelClick += (o, args) =>
            {
                try
                {
                    cts.Cancel();
                }
                catch (TaskCanceledException)
                {
                    // This is OK
                }
                catch (AggregateException ae) when (ae.InnerExceptions.OfType<TaskCanceledException>().Any())
                {
                    // This is OK
                }
                catch (Exception e)
                {
                    panel.Exception = e;
                }
            };
            parentControl.ResumeLayout();
            return panel;
        }

        private static void HideWaitPanel(Control parentControl, Control panel)
        {
            parentControl.SuspendLayout();
            parentControl.UseWaitCursor = false;
            panel.Visible = false;
            parentControl.Controls.Remove(panel);
            panel.Dispose();
            parentControl.ResumeLayout();
            if (parentControl is Form form)
            {
                form.DialogResult = DialogResult.OK;
            }
        }
    }
}