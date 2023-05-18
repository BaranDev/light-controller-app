namespace light_controller_app
{
    partial class LightController
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LightController));
            this.pnlMenuBar = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblCurrentMenu = new System.Windows.Forms.Label();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.pnlCurrentMenuIndicator = new System.Windows.Forms.Panel();
            this.btnRooms = new System.Windows.Forms.Button();
            this.btnDevices = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.parrotFormEllipse1 = new ReaLTaiizor.Controls.ParrotFormEllipse();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pbRobotGif = new System.Windows.Forms.PictureBox();
            this.pnlMenuBar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlNav.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRobotGif)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuBar
            // 
            this.pnlMenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.pnlMenuBar.Controls.Add(this.flowLayoutPanel1);
            this.pnlMenuBar.Controls.Add(this.pbLogo);
            this.pnlMenuBar.Controls.Add(this.lblCurrentMenu);
            this.pnlMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuBar.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuBar.Name = "pnlMenuBar";
            this.pnlMenuBar.Size = new System.Drawing.Size(804, 40);
            this.pnlMenuBar.TabIndex = 0;
            this.pnlMenuBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMenuBar_MouseDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnMin);
            this.flowLayoutPanel1.Controls.Add(this.btnExit);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(724, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(80, 40);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btnMin
            // 
            this.btnMin.AutoSize = true;
            this.btnMin.BackgroundImage = global::light_controller_app.Properties.Resources.btnMin;
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(20, 10);
            this.btnMin.Margin = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.btnMin.MaximumSize = new System.Drawing.Size(20, 20);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(20, 20);
            this.btnMin.TabIndex = 5;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackgroundImage = global::light_controller_app.Properties.Resources.btnExit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(47, 10);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 5, 5, 5);
            this.btnExit.MaximumSize = new System.Drawing.Size(20, 20);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 6;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(161, 40);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            this.pbLogo.Tag = "";
            this.toolTip1.SetToolTip(this.pbLogo, "github.com/barandev");
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // lblCurrentMenu
            // 
            this.lblCurrentMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentMenu.Font = new System.Drawing.Font("Konkhmer Sleokchher", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(120)))), ((int)(((byte)(141)))));
            this.lblCurrentMenu.Location = new System.Drawing.Point(0, 0);
            this.lblCurrentMenu.Margin = new System.Windows.Forms.Padding(3);
            this.lblCurrentMenu.Name = "lblCurrentMenu";
            this.lblCurrentMenu.Size = new System.Drawing.Size(804, 40);
            this.lblCurrentMenu.TabIndex = 3;
            this.lblCurrentMenu.Text = "Main Menu";
            this.lblCurrentMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCurrentMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblCurrentMenu_MouseDown);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.pnlNav.Controls.Add(this.pnlCurrentMenuIndicator);
            this.pnlNav.Controls.Add(this.btnRooms);
            this.pnlNav.Controls.Add(this.btnDevices);
            this.pnlNav.Controls.Add(this.btnHome);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNav.Location = new System.Drawing.Point(0, 380);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(804, 81);
            this.pnlNav.TabIndex = 2;
            // 
            // pnlCurrentMenuIndicator
            // 
            this.pnlCurrentMenuIndicator.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlCurrentMenuIndicator.Location = new System.Drawing.Point(0, 76);
            this.pnlCurrentMenuIndicator.MaximumSize = new System.Drawing.Size(161, 5);
            this.pnlCurrentMenuIndicator.Name = "pnlCurrentMenuIndicator";
            this.pnlCurrentMenuIndicator.Size = new System.Drawing.Size(161, 3);
            this.pnlCurrentMenuIndicator.TabIndex = 0;
            // 
            // btnRooms
            // 
            this.btnRooms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRooms.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRooms.FlatAppearance.BorderSize = 0;
            this.btnRooms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.btnRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRooms.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRooms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(120)))), ((int)(((byte)(141)))));
            this.btnRooms.Image = ((System.Drawing.Image)(resources.GetObject("btnRooms.Image")));
            this.btnRooms.Location = new System.Drawing.Point(322, 0);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnRooms.Size = new System.Drawing.Size(161, 81);
            this.btnRooms.TabIndex = 3;
            this.btnRooms.Text = "Rooms";
            this.btnRooms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnRooms, "See the devices in a room");
            this.btnRooms.UseVisualStyleBackColor = true;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // btnDevices
            // 
            this.btnDevices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDevices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevices.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDevices.FlatAppearance.BorderSize = 0;
            this.btnDevices.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.btnDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevices.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(120)))), ((int)(((byte)(141)))));
            this.btnDevices.Image = global::light_controller_app.Properties.Resources.bulb;
            this.btnDevices.Location = new System.Drawing.Point(161, 0);
            this.btnDevices.Name = "btnDevices";
            this.btnDevices.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnDevices.Size = new System.Drawing.Size(161, 81);
            this.btnDevices.TabIndex = 3;
            this.btnDevices.Text = "Devices";
            this.btnDevices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnDevices, "See all the devices");
            this.btnDevices.UseVisualStyleBackColor = true;
            this.btnDevices.Click += new System.EventHandler(this.btnDevices_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(120)))), ((int)(((byte)(141)))));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(161, 81);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Dashboard";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnHome, "Go to dashboard");
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // parrotFormEllipse1
            // 
            this.parrotFormEllipse1.CornerRadius = 25;
            this.parrotFormEllipse1.EffectedForm = this;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(32)))));
            this.pnlContent.Controls.Add(this.pbRobotGif);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 40);
            this.pnlContent.MinimumSize = new System.Drawing.Size(126, 50);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(804, 340);
            this.pnlContent.TabIndex = 3;
            // 
            // pbRobotGif
            // 
            this.pbRobotGif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbRobotGif.Image = global::light_controller_app.Properties.Resources.cyborg_search;
            this.pbRobotGif.Location = new System.Drawing.Point(0, 0);
            this.pbRobotGif.Name = "pbRobotGif";
            this.pbRobotGif.Size = new System.Drawing.Size(804, 340);
            this.pbRobotGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRobotGif.TabIndex = 0;
            this.pbRobotGif.TabStop = false;
            // 
            // LightController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(32)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.pnlMenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LightController";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Light Controller";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LightController_Load);
            this.pnlMenuBar.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlNav.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRobotGif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuBar;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblCurrentMenu;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private ReaLTaiizor.Controls.ParrotFormEllipse parrotFormEllipse1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlCurrentMenuIndicator;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Button btnDevices;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox pbRobotGif;
    }
}

