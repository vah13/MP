using System;
using System.Drawing;
using System.IO;

namespace MissionPlanner
{
    partial class Splash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private System.Windows.Forms.PictureBox airWorkerPictureBox;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_version = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.airWorkerPictureBox = new System.Windows.Forms.PictureBox(); // Перемещено сюда для правильной инициализации

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airWorkerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(417, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Tag = "custom";
            this.label1.Text = "with Support by AirWorker";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // airWorkerPictureBox
            // 
            // @vah_13 добавляем AIR WORKER под label1
            this.airWorkerPictureBox.Location = new System.Drawing.Point(447, 150); // Размещаем под label1
            this.airWorkerPictureBox.Name = "airWorkerPictureBox";
            this.airWorkerPictureBox.Size = new System.Drawing.Size(113, 100); // Настройте размер по необходимости
            this.airWorkerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.airWorkerPictureBox.BackColor = System.Drawing.Color.Transparent;

            // Строка Base64 вашего изображения
            string base64String = "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";

            // Декодируем строку Base64 и устанавливаем изображение
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (var ms = new MemoryStream(imageBytes))
            {
                this.airWorkerPictureBox.Image = Image.FromStream(ms);
            }

            // Добавляем PictureBox на форму
            this.Controls.Add(this.airWorkerPictureBox);

            // 
            // TXT_version
            // 
            this.TXT_version.BackColor = System.Drawing.Color.Transparent;
            this.TXT_version.ForeColor = System.Drawing.Color.White;
            this.TXT_version.Location = new System.Drawing.Point(403, 107);
            this.TXT_version.Name = "TXT_version";
            this.TXT_version.Size = new System.Drawing.Size(155, 25);
            this.TXT_version.TabIndex = 1;
            this.TXT_version.Text = "Version: ";
            this.TXT_version.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(207, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Splash
            // 
            this.BackgroundImage = global::MissionPlanner.Properties.Resources.splashdark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(584, 336);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TXT_version);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 375);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 375);
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mission Planner";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TXT_version;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}
