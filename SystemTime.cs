using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace WindowsFormsApp3
{

    public class SystemTime
    {
        public struct SYSTEMTIME
        {
            Int16 wYear;
            Int16 wMonth;
            Int16 wDayOfWeek;
            Int16 wDay;
            Int16 wHour;
            Int16 wMinute;
            Int16 wSecond;
            Int16 wMillisecond;
            public string GetRes()
            {
                return String.Format("{0}:{1}:{2}", wHour, wMinute, wSecond);
            }
        }


        [DllImport("Kernel32.dll", EntryPoint = "GetLocalTime")]
        public static extern void GetLocalTime(ref SYSTEMTIME lpSystemTime);


        public string GetTime() {
            SYSTEMTIME sYSTEMTIME = new SYSTEMTIME();
            GetLocalTime(ref sYSTEMTIME);
            return String.Format("The local time is : {0}", sYSTEMTIME.GetRes());
        }

    }
}