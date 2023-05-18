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
    public partial class ColorPicker : Form
    {
        public ColorPicker()
        {
            InitializeComponent();
        }

        private void btnCopyRgb_Click(object sender, EventArgs e)
        {
            string rgb = cyberColorPicker1.SelectedColor.R.ToString() + "," + cyberColorPicker1.SelectedColor.G.ToString() + "," + cyberColorPicker1.SelectedColor.B.ToString();
            //copy to clipboard
            Clipboard.SetText(rgb);
        }

        private void btnCopyHex_Click(object sender, EventArgs e)
        {
            string hex = "#" + cyberColorPicker1.SelectedColor.Name.ToUpper();
            //copy to clipboard
            Clipboard.SetText(hex);
        }
    }
}
