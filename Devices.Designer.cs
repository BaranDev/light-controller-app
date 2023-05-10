namespace light_controller_app
{
    partial class Devices
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
            this.parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.btnLoadDevices = new System.Windows.Forms.Button();
            this.btnSaveDevices = new System.Windows.Forms.Button();
            this.btnFindDevicesAuto = new System.Windows.Forms.Button();
            this.deviceListBox = new System.Windows.Forms.ListBox();
            this.btnOn = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.pnlDeviceStatus = new System.Windows.Forms.Panel();
            this.lblDeviceStatus = new System.Windows.Forms.Label();
            this.lblStatusText = new System.Windows.Forms.Label();
            this.parrotGradientPanel1.SuspendLayout();
            this.pnlDeviceStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // parrotGradientPanel1
            // 
            this.parrotGradientPanel1.BottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.parrotGradientPanel1.BottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotGradientPanel1.Controls.Add(this.btnLoadDevices);
            this.parrotGradientPanel1.Controls.Add(this.btnSaveDevices);
            this.parrotGradientPanel1.Controls.Add(this.btnFindDevicesAuto);
            this.parrotGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.parrotGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.parrotGradientPanel1.Name = "parrotGradientPanel1";
            this.parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotGradientPanel1.PrimerColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(32)))));
            this.parrotGradientPanel1.Size = new System.Drawing.Size(216, 340);
            this.parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            this.parrotGradientPanel1.TabIndex = 3;
            this.parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotGradientPanel1.TopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.parrotGradientPanel1.TopRight = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            // 
            // btnLoadDevices
            // 
            this.btnLoadDevices.FlatAppearance.BorderSize = 0;
            this.btnLoadDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadDevices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.btnLoadDevices.Location = new System.Drawing.Point(108, 288);
            this.btnLoadDevices.Name = "btnLoadDevices";
            this.btnLoadDevices.Size = new System.Drawing.Size(108, 23);
            this.btnLoadDevices.TabIndex = 5;
            this.btnLoadDevices.Text = "Load Devices";
            this.btnLoadDevices.UseVisualStyleBackColor = true;
            this.btnLoadDevices.Click += new System.EventHandler(this.btnLoadDevices_Click);
            // 
            // btnSaveDevices
            // 
            this.btnSaveDevices.FlatAppearance.BorderSize = 0;
            this.btnSaveDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDevices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.btnSaveDevices.Location = new System.Drawing.Point(0, 288);
            this.btnSaveDevices.Name = "btnSaveDevices";
            this.btnSaveDevices.Size = new System.Drawing.Size(108, 23);
            this.btnSaveDevices.TabIndex = 5;
            this.btnSaveDevices.Text = "Save Devices";
            this.btnSaveDevices.UseVisualStyleBackColor = true;
            this.btnSaveDevices.Click += new System.EventHandler(this.btnSaveDevices_Click);
            // 
            // btnFindDevicesAuto
            // 
            this.btnFindDevicesAuto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnFindDevicesAuto.FlatAppearance.BorderSize = 0;
            this.btnFindDevicesAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindDevicesAuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.btnFindDevicesAuto.Location = new System.Drawing.Point(0, 317);
            this.btnFindDevicesAuto.Name = "btnFindDevicesAuto";
            this.btnFindDevicesAuto.Size = new System.Drawing.Size(216, 23);
            this.btnFindDevicesAuto.TabIndex = 4;
            this.btnFindDevicesAuto.Text = "Discover Devices Automatically";
            this.btnFindDevicesAuto.UseVisualStyleBackColor = true;
            this.btnFindDevicesAuto.Click += new System.EventHandler(this.DiscoverButton_Click);
            // 
            // deviceListBox
            // 
            this.deviceListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.deviceListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deviceListBox.FormattingEnabled = true;
            this.deviceListBox.Location = new System.Drawing.Point(216, 1);
            this.deviceListBox.Name = "deviceListBox";
            this.deviceListBox.Size = new System.Drawing.Size(200, 338);
            this.deviceListBox.TabIndex = 5;
            this.deviceListBox.SelectedIndexChanged += new System.EventHandler(this.deviceListBox_SelectedIndexChanged);
            // 
            // btnOn
            // 
            this.btnOn.FlatAppearance.BorderSize = 0;
            this.btnOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOn.Font = new System.Drawing.Font("Georgia", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.btnOn.Location = new System.Drawing.Point(216, 289);
            this.btnOn.MaximumSize = new System.Drawing.Size(100, 50);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(80, 50);
            this.btnOn.TabIndex = 6;
            this.btnOn.Text = "TURN ON";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // btnOff
            // 
            this.btnOff.FlatAppearance.BorderSize = 0;
            this.btnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOff.Font = new System.Drawing.Font("Georgia", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.btnOff.Location = new System.Drawing.Point(336, 289);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(80, 50);
            this.btnOff.TabIndex = 6;
            this.btnOff.Text = "TURN OFF";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // pnlDeviceStatus
            // 
            this.pnlDeviceStatus.Controls.Add(this.lblDeviceStatus);
            this.pnlDeviceStatus.Controls.Add(this.lblStatusText);
            this.pnlDeviceStatus.Location = new System.Drawing.Point(296, 289);
            this.pnlDeviceStatus.Name = "pnlDeviceStatus";
            this.pnlDeviceStatus.Size = new System.Drawing.Size(40, 50);
            this.pnlDeviceStatus.TabIndex = 7;
            // 
            // lblDeviceStatus
            // 
            this.lblDeviceStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDeviceStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.lblDeviceStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.lblDeviceStatus.Location = new System.Drawing.Point(0, 13);
            this.lblDeviceStatus.Name = "lblDeviceStatus";
            this.lblDeviceStatus.Size = new System.Drawing.Size(40, 37);
            this.lblDeviceStatus.TabIndex = 9;
            this.lblDeviceStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDeviceStatus.TextChanged += new System.EventHandler(this.lblDeviceStatus_TextChanged);
            // 
            // lblStatusText
            // 
            this.lblStatusText.AutoSize = true;
            this.lblStatusText.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStatusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatusText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.lblStatusText.Location = new System.Drawing.Point(0, 0);
            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(43, 13);
            this.lblStatusText.TabIndex = 8;
            this.lblStatusText.Text = "Status";
            // 
            // Devices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(804, 340);
            this.Controls.Add(this.pnlDeviceStatus);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.deviceListBox);
            this.Controls.Add(this.parrotGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Devices";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Devices";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Devices_FormClosing);
            this.parrotGradientPanel1.ResumeLayout(false);
            this.pnlDeviceStatus.ResumeLayout(false);
            this.pnlDeviceStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private System.Windows.Forms.Button btnFindDevicesAuto;
        private System.Windows.Forms.Button btnSaveDevices;
        private System.Windows.Forms.Button btnLoadDevices;
        private System.Windows.Forms.ListBox deviceListBox;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Panel pnlDeviceStatus;
        private System.Windows.Forms.Label lblStatusText;
        private System.Windows.Forms.Label lblDeviceStatus;
    }
}