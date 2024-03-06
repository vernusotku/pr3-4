using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.CompilerServices;
using static WindowsFormsApp3.SysColor;

namespace WindowsFormsApp3
{
    public partial class ChangeSysColor : Form
    {
        public ChangeSysColor()
        {
            InitializeComponent();
        }
        int red, green, blue;
        SysColor sc = new SysColor();

        private void TackBar_Scroll(object sender, EventArgs e)
        {
            red = this.RedTackBar.Value;
            green = this.GreenTrackBar.Value;
            blue = this.BlueTrackBar.Value;
            string hexValue = "#"+red.ToString("X2") + green.ToString("X2") + blue.ToString("X2");
            this.pictureBox1.BackColor = ColorTranslator.FromHtml(hexValue);
            this.HEXColor.Text = hexValue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RGB rGB = new RGB();
            rGB.r = (byte)red;
            rGB.g = (byte)green;
            rGB.b = (byte)blue;
            bool @bool = sc.SetSysColor(rGB);
            if (@bool)
            {
                this.HEXDesktopColor.Text = sc.GetColor(1) + "\n" + "OK";
                MessageBox.Show("Изменение прошло успешно!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.HEXDesktopColor.Text = sc.GetColor(1) + "\n" + "FAIL";
                MessageBox.Show("Произошла ошибка!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
