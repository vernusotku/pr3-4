using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace WindowsFormsApp3
{
    class DriverDisk
    {
        [DllImport("kernel32.dll", EntryPoint = "GetLogicalDriveStrings")]
        public static extern uint GetLogicalDriveStrings(uint bufferLenght, StringBuilder buffer);


        public extern String[] GetDriveStrings() {
            uint bS = 256;
            StringBuilder sb = new StringBuilder((int)bS);
            uint res = GetLogicalDriveStrings(bS, sb);

            if (res > bS) {
                bS = res;
                sb = new StringBuilder((int)bS);
                GetLogicalDriveStrings(bS, sb);
            }

            return sb.ToString().TrimEnd('\0').Split('\0');
        }
    }
}
