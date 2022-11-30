using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWorkVII
{
    internal class Explorer
    {
        public static readonly DriveInfo[] _drives = DriveInfo.GetDrives();
        public static List<string> DirList = new List<string>();

        public static void Drives()
        {
            foreach (DriveInfo drive in _drives)
            {
                DirList.Add(drive.Name);
                Console.Write("   ");
                Console.Write(drive.Name);
                Console.WriteLine($" {drive.TotalFreeSpace / 1073741824} ГБ свободно из {drive.TotalSize / 1073741824} ГБ ");
            }
        }

        public static void Catalogs(int i)
        {
            string[] dirs = Directory.GetDirectories(Explorer.DirList[i]);
            Console.Clear();
            Program.Greetings();
            foreach (var VARIABLE in dirs)
            {
                Console.Write("   ");
                Console.WriteLine(VARIABLE);
            }
        }
    }
}