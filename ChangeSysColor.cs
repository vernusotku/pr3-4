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
        int Red, Green, Blue;
        SysColor sc = new SysColor();

        private void TackBar_Scroll(object sender, EventArgs e)
        {
            Red = this.RedTackBar.Value;
            Green = this.GreenTrackBar.Value;
            Blue = this.BlueTrackBar.Value;
            string hexValue = "#"+Red.ToString("X2") + Green.ToString("X2") + Blue.ToString("X2");
            this.pictureBox1.BackColor = ColorTranslator.FromHtml(hexValue);
            this.HEXColor.Text = hexValue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            COLORREF newColor = new COLORREF(Color.FromArgb(Red, Green, Blue));
            COLORREF[] colors = { newColor };
            bool @bool = sc.SetSysColor(colors);
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
