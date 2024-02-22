using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Security.Policy;

namespace WindowsFormsApp3
{
    internal class SystemInfo
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct SYSTEM_INFO {
            public uint dwOemId;
            public uint dwPageSize;
            public uint lpMinimumApplicationAddress;
            public uint lpMaximumApplicationAddress;
            public uint dwActiveProcessorMask;
            public uint dwNumberOfProcessors;
            public uint dwProcessorType;
            public uint dwAllocationGranularity;
            public uint dwProcessorLevel;
            public uint dwProcessorRevision;


            public string GetRes()
            {
                return String.Format("ID: {0}\nPagesize: {1}\nMinimumApplicationAddress: {2}\nMaximumApplicationAddress: {3}\nActiveProcessorMask: {4}\nNumberOfProcessors: {5},\nProcessorType: {6}\nAllocationGranularity: {7}\nProcessorLevel: {8}\nProcessorRevision: {9}",
                    dwOemId, dwPageSize, lpMinimumApplicationAddress, lpMaximumApplicationAddress, dwActiveProcessorMask, dwNumberOfProcessors, dwProcessorType, dwAllocationGranularity, dwProcessorLevel, dwProcessorRevision);

            }
        };
        [DllImport("kernel32.dll", EntryPoint = "GetSystemInfo")]
        public static extern void GetSystemInfo(ref SYSTEM_INFO lpSystemInfo);

        public string GetInfo()
        {
            SYSTEM_INFO lpSystemInfo = new SYSTEM_INFO();
            GetSystemInfo(ref lpSystemInfo);
            return lpSystemInfo.GetRes();
        }
    }
}

