using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApp3
{

    public partial class Form1 : Form
    {
        [DllImport("user32.dll", EntryPoint = "GetSystemMetrics")]
        public static extern int GetSystemMetrics(int nIndex);

        public Form1()
        {
            InitializeComponent();
        }


        public enum SystemMetric : int
        {
            SM_CXBORDER = 5,
        }




        private string GetInfo(string parametr)
        {
            switch (parametr)
            {
                case "GetComputerName + GetUserName":
                    return String.Format("Название компьютера {0}\nИмя пользователя: {1}", Environment.MachineName, System.Security.Principal.WindowsIdentity.GetCurrent().Name);
                case "GetSystemDirectory":
                    return String.Format("Системная директория: {0}", System.Environment.SystemDirectory);
                case "GetVersionEx":
                    return String.Format("Версия ОС: {0}",System.Environment.OSVersion);
                case "GetSystemMetrics":
                    return GetSystemMetrics(SystemMetric.SM_CXBORDER).ToString();
                default:
                    return "000";
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListBox lb = listBox1;
            string value = (string)lb.Items[lb.SelectedIndex];
            richTextBox1.Text = GetInfo(value);

        }

    }
}
