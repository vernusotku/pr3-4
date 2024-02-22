using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WindowsFormsApp3
{
    internal class SysColor
    {
        [DllImport("user32.dll", EntryPoint = "GetSysColor")]
        public static extern uint GetSysColor(int nIndex);
        enum nIndex
        {
            COLOR_3DFACE = 15,
            COLOR_BTNTEXT = 18,
            COLOR_WINDOWTEXT = 8

        }

        public string GetColor()
        {
            return String.Format("COLOR_3DFACE: {0}\nCOLOR_BTNTEXT: P{1}\n COLOR_WINDOWTEXT: {2}", GetSysColor((int)nIndex.COLOR_3DFACE), GetSysColor((int)nIndex.COLOR_BTNTEXT), GetSysColor((int)nIndex.COLOR_WINDOWTEXT));

        }
    }
}
