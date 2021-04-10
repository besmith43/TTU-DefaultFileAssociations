using System;
using System.IO;
using System.Security.Principal;

namespace TTU_DefaultFileAssociations
{
    class Program
    {
        static void Main(string[] args)
        {
            if (IsAdministrator())
            {
                if (File.Exists(@"C:\Program Files\Microsoft Office\root\Office16\OUTLOOK.exe"))
                {
                    // run dism for mailto
                }

                if (File.Exists(@"C:\Program Files\ImageGlass\ImageGlass.exe"))
                {
                    // run dism for imageglass
                }
            }
            else
            {
                Console.WriteLine("Please Run as Admin");
            }
        }

        public static bool IsAdministrator()
        {
            return (new WindowsPrincipal(WindowsIdentity.GetCurrent()))
                 .IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
