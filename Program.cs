using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWorkVII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Explorer drives = new Explorer();
            //drives.Drives();
            Greetings();
            Explorer.Drives();
            Strelka strelka = new Strelka();
            strelka.ChangePosition(3, 9);
        }

        public static void Greetings()
        {
            Console.SetCursorPosition(50, 0);
            Console.WriteLine("Этот компьютер");
            for (int i = 0; i < 120; i++) Console.Write("-");
            Console.WriteLine();
        }

    }
}
