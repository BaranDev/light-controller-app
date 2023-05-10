using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Extension;
using YeelightAPI;
using YeelightAPI.Models;

namespace light_controller_app
{
    public partial class Devices : Form
    {
        private StorageController storageController = new StorageController("devices.xml");
        private List<Device> deviceList = new List<Device>();
        private List<DeviceModel> deviceModelList = new List<DeviceModel>();

        public Devices()
        {
            InitializeComponent();
        }

        private void Devices_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save the devices to the XML file
            _SaveDevices();
        }

        private void _SaveDevices()
        {
            // Save the devices to the XML file
            storageController.SaveDevices(deviceList);
        }

        private void _LoadDevices()
        {
            deviceModelList = storageController.LoadDevices();
            deviceListBox.Items.Clear();

            // Add the devices to the list box
            foreach (DeviceModel deviceModel in deviceModelList)
            {
                deviceListBox.Items.Add(deviceModel.Hostname);
            }

            ;
        }


        private async Task DiscoverDevicesAsync()
        {
            try
            {
                // Discover devices on the network
                IEnumerable<Device> devices = await DeviceLocator.DiscoverAsync();

                // if deviceList doesn't contain the devices, add them to deviceList
                foreach (Device device in devices)
                {
                    if (!deviceList.Contains(device))
                    {
                        deviceList.Add(device);
                    }
                }

            }
            catch (DeviceDiscoveryException ex)
            {
                // Handle any exceptions that occur during device discovery
                MessageBox.Show($"Error discovering devices: {ex.Message}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void EnterLoadingPhase(string AnimationLocation, Control control)
        {
            LoadingForm loadingForm = new LoadingForm();
            loadingForm.TopLevel = false;
            loadingForm.StartPosition = FormStartPosition.Manual;

            if (control is ListBox || control is MetroListBox)
            {
                System.Windows.Forms.Panel panel = new System.Windows.Forms.Panel();
                panel.Size = loadingForm.Size;
                panel.MaximumSize = loadingForm.MaximumSize;
                loadingForm.Show();

                if (AnimationLocation == "middle")
                {
                    int x = control.DisplayRectangle.Left + (control.DisplayRectangle.Width - panel.Width) / 2;
                    int y = control.DisplayRectangle.Top + (control.DisplayRectangle.Height - panel.Height) / 2;
                    panel.Location = new Point(x, y);
                }

                loadingForm.Dock = DockStyle.Fill; // Set the DockStyle to Fill
                panel.Controls.Add(loadingForm);
                control.Controls.Add(panel);
                panel.Show();
            }
            else
            {
                if (AnimationLocation == "middle")
                {
                    int x = control.Left + (control.Width - loadingForm.Width) / 2;
                    int y = control.Top + (control.Height - loadingForm.Height) / 2;
                    loadingForm.Location = new Point(x, y);
                }

                control.Controls.Add(loadingForm);
                loadingForm.Show();
            }
        }







        private void LeaveLoadingPhase(Control control)
        {
            foreach (Control control1 in control.Controls.OfType<LoadingForm>().ToList())
            {
                deviceListBox.Controls.Remove(control1);
            }

            foreach (Control control1 in control.Controls.OfType<System.Windows.Forms.Panel>().ToList())
            {
                deviceListBox.Controls.Remove(control1);
            }
        }

        private void DiscoverButton_Click(object sender, EventArgs e)
        {
            EnterLoadingPhase("middle", deviceListBox);

            // Call the asynchronous method and wait for it to complete
            Task.Run(async () => await DiscoverDevicesAsync()).Wait();

            LeaveLoadingPhase(deviceListBox);

            // Save the devices
            _SaveDevices();

            //Load the devices
            _LoadDevices();
        }


        private void btnSaveDevices_Click(object sender, EventArgs e)
        {
            _SaveDevices();
        }

        private void btnLoadDevices_Click(object sender, EventArgs e)
        {

            _LoadDevices();
        }

        public Device SelectedDevice;
        public bool DeviceState;

        private async void deviceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Selected item's text
            string selectedDevice = deviceListBox.GetItemText(deviceListBox.SelectedItem);
            SelectedDevice = new Device(selectedDevice);
            await SelectedDevice.Connect();
            await UpdateState();
        }

        private async Task UpdateState()
        {
            await IsDeviceOn();
            lblDeviceStatus.Text = DeviceState ? "ON" : "OFF";
        }

        private async Task IsDeviceOn()
        {
            // Get the power state as an object
            object powerStateObject = await SelectedDevice.GetProp(PROPERTIES.power);
            // Check if the power state is "1" (on)
            bool isDeviceOn = powerStateObject?.ToString() == "on";
            // Set the label text based on the device status
            DeviceState = isDeviceOn ? true : false;

        }


        private async void btnOn_Click(object sender, EventArgs e)
        {
            SelectedDevice.TurnOn();
            await UpdateState();
        }

        private async void btnOff_Click(object sender, EventArgs e)
        {
            SelectedDevice.TurnOff();
            await UpdateState();
        }

        private void lblDeviceStatus_TextChanged(object sender, EventArgs e)
        {
            if (lblDeviceStatus.Text == "ON")
            {
                lblDeviceStatus.ForeColor = Color.FromArgb(0, 47, 56);
            }
            else if (lblDeviceStatus.Text == "OFF")
            {
                lblDeviceStatus.ForeColor = Color.FromArgb(58, 35, 0);
            }
        }
    }
}
