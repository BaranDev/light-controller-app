using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YeelightAPI;

namespace light_controller_app
{
    public partial class LightController : Form
    {
        public LightController()
        {
            InitializeComponent();
        }

        private void circularButton_Paint(object sender, PaintEventArgs e)
        {
            Button button = (Button)sender;
            using (GraphicsPath circularPath = new GraphicsPath())
            {
                circularPath.AddEllipse(0, 0, button.Width - 1, button.Height - 1);
                button.Region = new Region(circularPath);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

   

    // WinAPI constants
    private const int WM_NCLBUTTONDOWN = 0xA1;
    private const int HT_CAPTION = 0x2;

    // WinAPI functions
    [DllImport("user32.dll")]
    private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

    [DllImport("user32.dll")]
    private static extern bool ReleaseCapture();

        private void pnlMenuBar_MouseDown(object sender, MouseEventArgs e)
        {
            pnlMenuBar.MouseDown += customPanel_MouseDown;
        }

        private void lblCurrentMenu_MouseDown(object sender, MouseEventArgs e)
        {
            lblCurrentMenu.MouseDown += customPanel_MouseDown;
        }




        private void customPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void LogoClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/barandev");
        }
        
        private void pbLogo_Click(object sender, EventArgs e)
        {
            pbLogo.Click += LogoClicked;
        }
    }
}
