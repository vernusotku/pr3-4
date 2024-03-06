using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices.WindowsRuntime;

namespace WindowsFormsApp3
{
    class SysColor
    {
        [DllImport("user32.dll", EntryPoint = "GetSysColor")]
        public static extern uint GetSysColor(int nIndex);

        [DllImport("user32.dll", EntryPoint = "SetSysColors")]
        public static extern bool SetSysColors(int cElements, int nIndex, RGB dwSysColor);


        enum nIndex
        {
            COLOR_3DFACE = 15,
            COLOR_BTNTEXT = 18,
            COLOR_WINDOWTEXT = 8,
            COLOR_DESKTOP = 1,
            COLOR_WINDOW = 5,
            COLOR_WINDOWFRAME = 6,
            COLOR_ACTIVECAPTION = 2

        }
        public struct RGB
        {
            public byte r;
            public byte g;
            public byte b;
        }

        public string GetColor(int type)
        {   
            switch (type)
            {
                case 0: return String.Format("COLOR_3DFACE: {0}\nCOLOR_BTNTEXT: P{1}\n COLOR_WINDOWTEXT: {2}", GetSysColor((int)nIndex.COLOR_3DFACE), GetSysColor((int)nIndex.COLOR_BTNTEXT), GetSysColor((int)nIndex.COLOR_WINDOWTEXT));
                case 1: return GetSysColor((int)nIndex.COLOR_WINDOW).ToString("X6");
            }
            throw new Exception("Не пон...");
        }

        public bool SetSysColor(RGB dwSysColor) {
            Console.WriteLine(dwSysColor.b);
            return SetSysColors(1,(int)nIndex.COLOR_WINDOW, dwSysColor); }
        }
    }

