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
        //Device device = new Device(DeviceLocator.DiscoverAsync().Result.ToString()); //test this feature
        
        
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

        private void NavButtonClicked(Button button,String formToAdd)
        {
            switch (formToAdd)
            {
                case "dashboard":
                    {
                        if (pnlContent.Controls.Count == 0 || pnlContent.Controls[0].GetType() != typeof(Dashboard))
                        {
                            lblCurrentMenu.Text = "Dashboard";
                            pnlContent.Controls.Clear();
                            Dashboard dashboard = new Dashboard();
                            dashboard.TopLevel = false;
                            dashboard.FormBorderStyle = FormBorderStyle.None;
                            dashboard.Dock = DockStyle.Fill;
                            pnlContent.Controls.Add(dashboard);
                            pnlContent.Tag = dashboard;
                            dashboard.BringToFront();
                            dashboard.Show();
                        }
                        else
                            ResetContentPanel();
                        break;
                    }

                case "rooms":
                    {
                        if (pnlContent.Controls.Count == 0 || pnlContent.Controls[0].GetType() != typeof(Rooms))
                        {
                            lblCurrentMenu.Text = "Rooms";
                            pnlContent.Controls.Clear();
                            Rooms rooms = new Rooms();
                            rooms.TopLevel = false;
                            rooms.FormBorderStyle = FormBorderStyle.None;
                            rooms.Dock = DockStyle.Fill;
                            pnlContent.Controls.Add(rooms);
                            pnlContent.Tag = rooms;
                            rooms.BringToFront();
                            rooms.Show();
                        }
                        else
                            ResetContentPanel();
                        break;
                    }

                case "devices":
                    {
                        if (pnlContent.Controls.Count == 0 || pnlContent.Controls[0].GetType() != typeof(Devices))
                        {
                            lblCurrentMenu.Text = "Devices";
                            pnlContent.Controls.Clear();
                            Devices devices = new Devices();
                            devices.TopLevel = false;
                            devices.FormBorderStyle = FormBorderStyle.None;
                            devices.Dock = DockStyle.Fill;
                            pnlContent.Controls.Add(devices);
                            pnlContent.Tag = devices;
                            devices.BringToFront();
                            devices.Show();
                        }
                        else
                            ResetContentPanel();
                        break;
                    }



            }
            // Reset the color of all buttons to the original color (27, 22, 40)
            foreach (Button btn in pnlNav.Controls.OfType<Button>())
            {
                btn.BackColor = Color.FromArgb(27, 22, 40);
            }

            // Change the color of the clicked button to the desired color (47, 42, 60)
            button.BackColor = Color.FromArgb(47, 42, 60);

            // Move pnlCurrentMenuIndicator to the bottom of the clicked button
            pnlCurrentMenuIndicator.Width = button.Width;
            pnlCurrentMenuIndicator.Location = new Point(button.Location.X, button.Location.Y + button.Height - pnlCurrentMenuIndicator.MaximumSize.Height);
        }

        private void ResetContentPanel()
        {
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(pbRobotGif);
            lblCurrentMenu.Text = "Main Menu";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            NavButtonClicked(btnHome, "dashboard");
        }

        private void btnDevices_Click(object sender, EventArgs e)
        {
            NavButtonClicked(btnDevices, "devices");
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            NavButtonClicked(btnRooms, "rooms");
        }

        private void LightController_Load(object sender, EventArgs e)
        {

        }
    }
}
