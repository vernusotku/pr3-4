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
using System.Drawing;

namespace WindowsFormsApp3
{
    class SysColor
    {
        [DllImport("user32.dll", EntryPoint = "GetSysColor")]
        public static extern uint GetSysColor(int nIndex);

        [DllImport("user32.dll", EntryPoint = "SetSysColors")]
        public static extern bool SetSysColors(int cElements, int[] nIndex, COLORREF[] dwSysColor);

        public struct COLORREF {
            public uint ColorDWORD;
            public COLORREF(Color color)
            {
                ColorDWORD = color.R + (((uint)color.G) << 8) + (((uint)color.B) << 16);
            }
            public Color GetColor()
            {
                return Color.FromArgb((int)(0x000000FFU & ColorDWORD),
                    (int)(0x0000FF00U & ColorDWORD) << 8, (int)(0x00FF0000U & ColorDWORD) << 16);
            }

            public void SetColor(Color color)
            {
                ColorDWORD = color.R + (((uint)color.G) << 8) + (((uint)color.B) << 16);
            }
        
        }

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
        public string GetColor(int type)
        {   
            switch (type)
            {
                case 0: return String.Format("COLOR_3DFACE: {0}\nCOLOR_BTNTEXT: P{1}\n COLOR_WINDOWTEXT: {2}", GetSysColor((int)nIndex.COLOR_3DFACE), GetSysColor((int)nIndex.COLOR_BTNTEXT), GetSysColor((int)nIndex.COLOR_WINDOWTEXT));
                case 1: return GetSysColor((int)nIndex.COLOR_DESKTOP).ToString("X6");
            }
            throw new Exception("Не пон...");
        }

        public bool SetSysColor(COLORREF[] lColor) {
            int[] lI = { (int)nIndex.COLOR_DESKTOP };
            return SetSysColors(lI.Length, lI, lColor); }
        }
    }

