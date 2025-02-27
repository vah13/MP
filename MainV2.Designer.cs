using System;
using System.IO;

namespace MissionPlanner
{
    partial class MainV2
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
            Console.WriteLine("mainv2_Dispose");
            if (PluginThreadrunner != null)
                PluginThreadrunner.Dispose();
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainV2));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.CTX_mainmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.autoHideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readonlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFlightData = new System.Windows.Forms.ToolStripButton();
            this.MenuFlightPlanner = new System.Windows.Forms.ToolStripButton();
            this.MenuInitConfig = new System.Windows.Forms.ToolStripButton();
            this.MenuConfigTune = new System.Windows.Forms.ToolStripButton();
            this.MenuSimulation = new System.Windows.Forms.ToolStripButton();
            this.MenuHelp = new System.Windows.Forms.ToolStripButton();
            this.MenuConnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripConnectionControl = new MissionPlanner.Controls.ToolStripConnectionControl();
            this.MenuArduPilot = new System.Windows.Forms.ToolStripButton();
            this.menu = new MissionPlanner.Controls.MyButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.status1 = new MissionPlanner.Controls.Status();
            
            // @vah_13 START
            this.MenuInitConfig.Enabled = false;
            this.MenuConfigTune.Enabled = false;
            this.MenuSimulation.Enabled = false;
            this.MenuHelp.Enabled = false;
            // @vah_13 END

            this.MainMenu.SuspendLayout();
            this.CTX_mainmenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            resources.ApplyResources(this.MainMenu, "MainMenu");
            this.MainMenu.ContextMenuStrip = this.CTX_mainmenu;
            this.MainMenu.GripMargin = new System.Windows.Forms.Padding(0);
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(45, 39);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFlightData,
            this.MenuFlightPlanner,
            this.MenuInitConfig,
            this.MenuConfigTune,
            this.MenuSimulation,
            this.MenuHelp,
            this.MenuConnect,
            this.toolStripConnectionControl,
            this.MenuArduPilot});
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.ShowItemToolTips = true;
            //this.MainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MainMenu_ItemClicked);
            //this.MainMenu.MouseLeave += new System.EventHandler(this.MainMenu_MouseLeave);
            // 
            // CTX_mainmenu
            // 
            this.CTX_mainmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            /*this.autoHideToolStripMenuItem,
            this.fullScreenToolStripMenuItem,
            this.readonlyToolStripMenuItem,
            this.connectionOptionsToolStripMenuItem,
            this.connectionListToolStripMenuItem*/});
            this.CTX_mainmenu.Name = "CTX_mainmenu";
            resources.ApplyResources(this.CTX_mainmenu, "CTX_mainmenu");
            // 
            // autoHideToolStripMenuItem
            // 
            this.autoHideToolStripMenuItem.CheckOnClick = true;
            this.autoHideToolStripMenuItem.Name = "autoHideToolStripMenuItem";
            resources.ApplyResources(this.autoHideToolStripMenuItem, "autoHideToolStripMenuItem");
            this.autoHideToolStripMenuItem.Click += new System.EventHandler(this.autoHideToolStripMenuItem_Click);
            // 
            // fullScreenToolStripMenuItem
            // 
            this.fullScreenToolStripMenuItem.CheckOnClick = true;
            this.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
            resources.ApplyResources(this.fullScreenToolStripMenuItem, "fullScreenToolStripMenuItem");
            this.fullScreenToolStripMenuItem.Click += new System.EventHandler(this.fullScreenToolStripMenuItem_Click);
            // 
            // readonlyToolStripMenuItem
            // 
            this.readonlyToolStripMenuItem.CheckOnClick = true;
            this.readonlyToolStripMenuItem.Name = "readonlyToolStripMenuItem";
            resources.ApplyResources(this.readonlyToolStripMenuItem, "readonlyToolStripMenuItem");
            this.readonlyToolStripMenuItem.Click += new System.EventHandler(this.readonlyToolStripMenuItem_Click);
            // 
            // connectionOptionsToolStripMenuItem
            // 
            this.connectionOptionsToolStripMenuItem.Name = "connectionOptionsToolStripMenuItem";
            resources.ApplyResources(this.connectionOptionsToolStripMenuItem, "connectionOptionsToolStripMenuItem");
            this.connectionOptionsToolStripMenuItem.Click += new System.EventHandler(this.connectionOptionsToolStripMenuItem_Click);
            // 
            // connectionListToolStripMenuItem
            // 
            this.connectionListToolStripMenuItem.Name = "connectionListToolStripMenuItem";
            resources.ApplyResources(this.connectionListToolStripMenuItem, "connectionListToolStripMenuItem");
            this.connectionListToolStripMenuItem.Click += new System.EventHandler(this.connectionListToolStripMenuItem_Click);
            // 
            // MenuFlightData
            // 
            this.MenuFlightData.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.MenuFlightData, "MenuFlightData");
            this.MenuFlightData.Margin = new System.Windows.Forms.Padding(0);
            this.MenuFlightData.Name = "MenuFlightData";
            this.MenuFlightData.Click += new System.EventHandler(this.MenuFlightData_Click);
            // 
            // MenuFlightPlanner
            // 
            this.MenuFlightPlanner.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.MenuFlightPlanner, "MenuFlightPlanner");
            this.MenuFlightPlanner.Margin = new System.Windows.Forms.Padding(0);
            this.MenuFlightPlanner.Name = "MenuFlightPlanner";
            this.MenuFlightPlanner.Click += new System.EventHandler(this.MenuFlightPlanner_Click);
            // 
            // MenuInitConfig
            // 
            this.MenuInitConfig.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.MenuInitConfig, "MenuInitConfig");
            this.MenuInitConfig.Margin = new System.Windows.Forms.Padding(0);
            this.MenuInitConfig.Name = "MenuInitConfig";
            this.MenuInitConfig.Click += new System.EventHandler(this.MenuSetup_Click);
            // 
            // MenuConfigTune
            // 
            this.MenuConfigTune.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.MenuConfigTune, "MenuConfigTune");
            this.MenuConfigTune.Margin = new System.Windows.Forms.Padding(0);
            this.MenuConfigTune.Name = "MenuConfigTune";
            this.MenuConfigTune.Click += new System.EventHandler(this.MenuTuning_Click);
            // 
            // MenuSimulation
            // 
            this.MenuSimulation.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.MenuSimulation, "MenuSimulation");
            this.MenuSimulation.Margin = new System.Windows.Forms.Padding(0);
            this.MenuSimulation.Name = "MenuSimulation";
            this.MenuSimulation.Click += new System.EventHandler(this.MenuSimulation_Click);
            // 
            // MenuHelp
            // 
            this.MenuHelp.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.MenuHelp, "MenuHelp");
            this.MenuHelp.Margin = new System.Windows.Forms.Padding(0);
            this.MenuHelp.Name = "MenuHelp";
            this.MenuHelp.Click += new System.EventHandler(this.MenuHelp_Click);
            // 
            // MenuConnect
            // 
            this.MenuConnect.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MenuConnect.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.MenuConnect, "MenuConnect");
            this.MenuConnect.Margin = new System.Windows.Forms.Padding(0);
            this.MenuConnect.Name = "MenuConnect";
            this.MenuConnect.Click += new System.EventHandler(this.MenuConnect_Click);
            // 
            // toolStripConnectionControl
            // 
            this.toolStripConnectionControl.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.toolStripConnectionControl, "toolStripConnectionControl");
            this.toolStripConnectionControl.ForeColor = System.Drawing.Color.Black;
            this.toolStripConnectionControl.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripConnectionControl.Name = "toolStripConnectionControl";
            this.toolStripConnectionControl.MouseLeave += new System.EventHandler(this.MainMenu_MouseLeave);
            // 
            // MenuArduPilot
            // 
            this.MenuArduPilot.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.MenuArduPilot, "MenuArduPilot");
            this.MenuArduPilot.BackColor = System.Drawing.Color.Transparent;
            this.MenuArduPilot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MenuArduPilot.ForeColor = System.Drawing.Color.White;

            string base64String = "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";
            byte[] imageData = Convert.FromBase64String(base64String);

            // Create a MemoryStream and load it into the Image property:
            using (var ms = new System.IO.MemoryStream(imageData))
            {
                this.MenuArduPilot.Image = System.Drawing.Image.FromStream(ms);
            }

            this.MenuArduPilot.Margin = new System.Windows.Forms.Padding(0);
            this.MenuArduPilot.Name = "MenuArduPilot";
            this.MenuArduPilot.Click += new System.EventHandler(this.MenuArduPilot_Click);
            // 
            // menu
            // 
            resources.ApplyResources(this.menu, "menu");
            this.menu.Name = "menu";
            this.menu.UseVisualStyleBackColor = true;
            this.menu.MouseEnter += new System.EventHandler(this.menu_MouseEnter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.status1);
            this.panel1.Controls.Add(this.MainMenu);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.MouseLeave += new System.EventHandler(this.MainMenu_MouseLeave);
            // 
            // status1
            // 
            resources.ApplyResources(this.status1, "status1");
            this.status1.Name = "status1";
            this.status1.Percent = 0D;
            // 
            // MainV2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu);
            this.KeyPreview = true;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainV2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainV2_KeyDown);
            this.Resize += new System.EventHandler(this.MainV2_Resize);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.CTX_mainmenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ToolStripButton MenuFlightData;
        public System.Windows.Forms.ToolStripButton MenuFlightPlanner;
        public System.Windows.Forms.ToolStripButton MenuInitConfig;
        public System.Windows.Forms.ToolStripButton MenuSimulation;
        public System.Windows.Forms.ToolStripButton MenuConfigTune;
        public System.Windows.Forms.ToolStripButton MenuConnect;
        private Controls.ToolStripConnectionControl toolStripConnectionControl;
        private Controls.MyButton menu;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip CTX_mainmenu;
        private System.Windows.Forms.ToolStripMenuItem autoHideToolStripMenuItem;
        public System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readonlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionListToolStripMenuItem;
        public System.Windows.Forms.ToolStripButton MenuHelp;
        public System.Windows.Forms.ToolStripButton MenuArduPilot;
        public Controls.Status status1;
    }
}