using System;
using System.Windows.Forms;


namespace WindowsFormsApp3
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private SystemMetric sm = new SystemMetric();
        private SystemTime lt = new SystemTime();
        private SystemInfo si = new SystemInfo();
        private SysColor sc = new SysColor();






        private string GetInfo(string parametr)
        {
            switch (parametr)
            {
                case "GetComputerName + GetUserName":
                    return String.Format("Название компьютера {0}\nИмя пользователя: {1}", Environment.MachineName, System.Security.Principal.WindowsIdentity.GetCurrent().Name);
                case "GetSystemDirectory":
                    return String.Format("Системная директория: {0}", System.Environment.SystemDirectory);
                case "GetVersionEx":
                    return String.Format("Версия ОС: {0}", System.Environment.OSVersion);
                case "GetSystemMetrics":
                    return sm.GetInfo();
                case "GetLocalTime":
                    return lt.GetTime();
                case "GetSystemInfo":
                     return si.GetInfo();
                case "GetSysColor": 
                    return sc.GetColor(0);  
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

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeSysColor changeSysColor = new ChangeSysColor();
            changeSysColor.HEXDesktopColor.Text = sc.GetColor(1);
            changeSysColor.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MathematicQuiz mq = new MathematicQuiz();
            mq.Show();
        }
    }
}
