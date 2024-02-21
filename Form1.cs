using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp3.SystemMetric;

namespace WindowsFormsApp3
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private SystemMetric sm = new SystemMetric();
/// TODO:
/// GetLocalTime: Создать класс и извлечь фигни https://learn.microsoft.com/en-us/previous-versions/aa915317(v=msdn.10)
/// GetSystemlnfo: понять и простить :с (https://learn.microsoft.com/ru-ru/windows/win32/api/sysinfoapi/nf-sysinfoapi-getsysteminfo)
/// GetSysColor or SetSysColor:(Ой бл..........) https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-getsyscolor 






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
                    return sm.GetInfo();
                case "GetLocalTime":
                    return "Ну и хуйня твое время...";
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
