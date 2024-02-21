using System.Runtime.InteropServices;

namespace WindowsFormsApp3
{
      public class SystemMetric
      {
          [DllImport("user32.dll", EntryPoint = "GetSystemMetrics")]
          public static extern int GetSystemMetrics(int nIndex);
  
          public enum SystemMetricType : int
          {
              SM_ARRANGE = 56,
          
              SM_CLEANBOOT = 67,
          
              SM_CMONITORS = 80,
          
              SM_CMOUSEBUTTONS = 43,
          
              SM_CONVERTIBLESLATEMODE = 0x2003,
         
              SM_CXBORDER = 5,
          
              SM_CXCURSOR = 13,
              
              SM_CXDLGFRAME = 7,
              
              SM_CXDOUBLECLK = 36,
              
              SM_CXDRAG = 68,
              
              SM_CXEDGE = 45,
              
              SM_CXFIXEDFRAME = 7,
              
              SM_CXFOCUSBORDER = 83,
              
              SM_CXFRAME = 32,
              SM_CXFULLSCREEN = 16,
              SM_CXHSCROLL = 21,
              
              SM_CXHTHUMB = 10,
              SM_CXICON = 11,
              SM_CXICONSPACING = 38,
              SM_CXMAXIMIZED = 61,
              SM_CXSCREEN = 0,
              SM_CYSCREEN = 1
              
          }
  
          private string GetInfoTypeBoot()
          {
              int value = GetSystemMetrics((int)SystemMetricType.SM_CLEANBOOT);
              switch (value)
              {
                  case 0: return "Normal Boot";
                  case 1: return "Fail Safe-Boot";
                  case 2: return "Fail-save with network boot";
                  default: return "Don't init...";
              }
          }
  
          public string GetInfo()
          {
              return string.Format("Info Display:{0}x{1}\nBoot: {2}",
                  GetSystemMetrics((int)SystemMetricType.SM_CXSCREEN),
                  GetSystemMetrics((int)SystemMetricType.SM_CYSCREEN),
                  GetInfoTypeBoot());;
          }
      }
}
