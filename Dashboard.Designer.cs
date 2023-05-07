namespace light_controller_app
{
    partial class Dashboard
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
            this.cyberColorPicker1 = new ReaLTaiizor.Controls.CyberColorPicker();
            this.thunderGroupBox1 = new ReaLTaiizor.Controls.ThunderGroupBox();
            this.btnCopyRgb = new ReaLTaiizor.Controls.CyberButton();
            this.btnCopyHex = new ReaLTaiizor.Controls.CyberButton();
            this.parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.thunderGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cyberColorPicker1
            // 
            this.cyberColorPicker1.BackColor = System.Drawing.Color.Transparent;
            this.cyberColorPicker1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.cyberColorPicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cyberColorPicker1.ForeColor = System.Drawing.Color.Black;
            this.cyberColorPicker1.Location = new System.Drawing.Point(20, 40);
            this.cyberColorPicker1.Name = "cyberColorPicker1";
            this.cyberColorPicker1.Padding = new System.Windows.Forms.Padding(50, 50, 50, 50);
            this.cyberColorPicker1.SelectedColor = System.Drawing.Color.Empty;
            this.cyberColorPicker1.Size = new System.Drawing.Size(176, 245);
            this.cyberColorPicker1.TabIndex = 0;
            this.cyberColorPicker1.Tag = "Cyber";
            this.cyberColorPicker1.Load += new System.EventHandler(this.cyberColorPicker1_Load);
            // 
            // thunderGroupBox1
            // 
            this.thunderGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.thunderGroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.thunderGroupBox1.BodyColorA = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(32)))));
            this.thunderGroupBox1.BodyColorB = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(32)))));
            this.thunderGroupBox1.BodyColorC = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.thunderGroupBox1.BodyColorD = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.thunderGroupBox1.Controls.Add(this.btnCopyHex);
            this.thunderGroupBox1.Controls.Add(this.btnCopyRgb);
            this.thunderGroupBox1.Controls.Add(this.cyberColorPicker1);
            this.thunderGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(120)))), ((int)(((byte)(141)))));
            this.thunderGroupBox1.Location = new System.Drawing.Point(170, 12);
            this.thunderGroupBox1.Name = "thunderGroupBox1";
            this.thunderGroupBox1.Padding = new System.Windows.Forms.Padding(20, 40, 20, 20);
            this.thunderGroupBox1.Size = new System.Drawing.Size(216, 305);
            this.thunderGroupBox1.TabIndex = 1;
            this.thunderGroupBox1.Text = "Color Picker";
            // 
            // btnCopyRgb
            // 
            this.btnCopyRgb.Alpha = 20;
            this.btnCopyRgb.BackColor = System.Drawing.Color.Transparent;
            this.btnCopyRgb.Background = false;
            this.btnCopyRgb.Background_WidthPen = 4F;
            this.btnCopyRgb.BackgroundPen = true;
            this.btnCopyRgb.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(120)))), ((int)(((byte)(141)))));
            this.btnCopyRgb.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(96)))), ((int)(((byte)(108)))));
            this.btnCopyRgb.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(75)))));
            this.btnCopyRgb.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(120)))), ((int)(((byte)(141)))));
            this.btnCopyRgb.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(120)))), ((int)(((byte)(141)))));
            this.btnCopyRgb.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnCopyRgb.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(141)))), ((int)(((byte)(125)))));
            this.btnCopyRgb.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnCopyRgb.Effect_1 = true;
            this.btnCopyRgb.Effect_1_ColorBackground = System.Drawing.Color.Black;
            this.btnCopyRgb.Effect_1_Transparency = 25;
            this.btnCopyRgb.Effect_2 = true;
            this.btnCopyRgb.Effect_2_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.btnCopyRgb.Effect_2_Transparency = 20;
            this.btnCopyRgb.Font = new System.Drawing.Font("Arial", 8.5F);
            this.btnCopyRgb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(120)))), ((int)(((byte)(141)))));
            this.btnCopyRgb.Lighting = true;
            this.btnCopyRgb.LinearGradient_Background = false;
            this.btnCopyRgb.LinearGradientPen = false;
            this.btnCopyRgb.Location = new System.Drawing.Point(20, 256);
            this.btnCopyRgb.Name = "btnCopyRgb";
            this.btnCopyRgb.PenWidth = 5;
            this.btnCopyRgb.Rounding = true;
            this.btnCopyRgb.RoundingInt = 80;
            this.btnCopyRgb.Size = new System.Drawing.Size(80, 38);
            this.btnCopyRgb.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnCopyRgb.TabIndex = 1;
            this.btnCopyRgb.Tag = "Cyber";
            this.btnCopyRgb.TextButton = "Copy RGB";
            this.btnCopyRgb.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnCopyRgb.Timer_Effect_1 = 5;
            this.btnCopyRgb.Timer_RGB = 300;
            this.btnCopyRgb.Click += new System.EventHandler(this.btnCopyRgb_Click);
            // 
            // btnCopyHex
            // 
            this.btnCopyHex.Alpha = 20;
            this.btnCopyHex.BackColor = System.Drawing.Color.Transparent;
            this.btnCopyHex.Background = false;
            this.btnCopyHex.Background_WidthPen = 4F;
            this.btnCopyHex.BackgroundPen = true;
            this.btnCopyHex.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(120)))), ((int)(((byte)(141)))));
            this.btnCopyHex.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(96)))), ((int)(((byte)(108)))));
            this.btnCopyHex.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(207)))), ((int)(((byte)(75)))));
            this.btnCopyHex.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(120)))), ((int)(((byte)(141)))));
            this.btnCopyHex.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(120)))), ((int)(((byte)(141)))));
            this.btnCopyHex.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnCopyHex.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(141)))), ((int)(((byte)(125)))));
            this.btnCopyHex.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnCopyHex.Effect_1 = true;
            this.btnCopyHex.Effect_1_ColorBackground = System.Drawing.Color.Black;
            this.btnCopyHex.Effect_1_Transparency = 25;
            this.btnCopyHex.Effect_2 = true;
            this.btnCopyHex.Effect_2_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.btnCopyHex.Effect_2_Transparency = 20;
            this.btnCopyHex.Font = new System.Drawing.Font("Arial", 8.5F);
            this.btnCopyHex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(120)))), ((int)(((byte)(141)))));
            this.btnCopyHex.Lighting = true;
            this.btnCopyHex.LinearGradient_Background = false;
            this.btnCopyHex.LinearGradientPen = false;
            this.btnCopyHex.Location = new System.Drawing.Point(116, 256);
            this.btnCopyHex.Name = "btnCopyHex";
            this.btnCopyHex.PenWidth = 5;
            this.btnCopyHex.Rounding = true;
            this.btnCopyHex.RoundingInt = 80;
            this.btnCopyHex.Size = new System.Drawing.Size(80, 38);
            this.btnCopyHex.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnCopyHex.TabIndex = 1;
            this.btnCopyHex.Tag = "Cyber";
            this.btnCopyHex.TextButton = "Copy HEX";
            this.btnCopyHex.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnCopyHex.Timer_Effect_1 = 5;
            this.btnCopyHex.Timer_RGB = 300;
            this.btnCopyHex.Click += new System.EventHandler(this.btnCopyHex_Click);
            // 
            // parrotGradientPanel1
            // 
            this.parrotGradientPanel1.BottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.parrotGradientPanel1.BottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.parrotGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.parrotGradientPanel1.Name = "parrotGradientPanel1";
            this.parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotGradientPanel1.PrimerColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(32)))));
            this.parrotGradientPanel1.Size = new System.Drawing.Size(161, 340);
            this.parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            this.parrotGradientPanel1.TabIndex = 2;
            this.parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotGradientPanel1.TopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.parrotGradientPanel1.TopRight = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.parrotGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.parrotGradientPanel1_Paint);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(804, 340);
            this.Controls.Add(this.parrotGradientPanel1);
            this.Controls.Add(this.thunderGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dashboard";
            this.thunderGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.CyberColorPicker cyberColorPicker1;
        private ReaLTaiizor.Controls.ThunderGroupBox thunderGroupBox1;
        private ReaLTaiizor.Controls.CyberButton btnCopyRgb;
        private ReaLTaiizor.Controls.CyberButton btnCopyHex;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
    }
}