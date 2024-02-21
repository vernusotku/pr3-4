using System.Runtime.InteropServices;

namespace WindowsFormsApp3
{

    public class SystemTime
    {
        [DllImport("Kernel32.dll")]
        public static extern void GetLocalTime(ref SystemTime lpSystemTime);
    }
}