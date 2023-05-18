using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace light_controller_app
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        /*
        
                                                    ⬇️--\TO-DO/--⬇️
        
        ➡️ Lightbulb Status: 
                Display the current status of the lightbulb(s) such as on/off, brightness level, and color.
        ➡️ On/Off Controls: 
                Provide a toggle switch or button to turn the lightbulb on and off.
        ➡️ Brightness Control: 
                Include a slider or numeric input to adjust the brightness level of the lightbulb.
        ➡️ Color Control: 
                Offer a color picker or preset color options to select and change the color of the lightbulb.
        ➡️ Scene Presets: 
                Allow users to save and recall predefined lighting scenes or moods, such as "Relaxation," "Reading," or "Party."
        ➡️ Scheduling: 
                Enable users to set timers or schedules to automatically turn the lightbulb on/off or change settings at specific times.
        ➡️ Grouping and Individual Control: 
                If multiple lightbulbs are connected, provide the ability to control them individually or group them together for simultaneous control.
        ➡️ Energy Usage Monitoring: 
                Show energy consumption statistics or real-time energy usage to help users track and manage their energy usage.
        ➡️ Notifications: 
                Send notifications or alerts for events like low battery, firmware updates, or unusual activity.
        ➡️ User Preferences: 
                Allow users to customize and save their preferred settings, such as default brightness or color preferences.
        ➡️ Help and Support: 
                Provide access to a help section, FAQs, or customer support contact information for any assistance or troubleshooting.
        
         */
        

      

        private void cyberColorPicker1_Load(object sender, EventArgs e)
        {

        }

        private void parrotGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnColorPicker_Click(object sender, EventArgs e) // change this to tools button
        {
            
            ColorPicker colorPicker = new ColorPicker();
            colorPicker.TopLevel = false;
            if (parrotGradientPanel1.Controls.Count == 1 || parrotGradientPanel1.Controls[1].GetType() != typeof(ColorPicker))
            {
                parrotGradientPanel1.Controls.Add(colorPicker);
                colorPicker.Show();
                
            }
            else
            {
                parrotGradientPanel1.Controls.RemoveAt(1);
            }





        }
    }
}
