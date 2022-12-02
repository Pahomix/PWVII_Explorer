using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWorkVII
{
    internal class Strelka
    {
        public int MinPosition;
        public int MaxPosition;
        private int _position = 2;
        private int selected = -1;
        private int oldsel = 0;

        public Strelka()
        {

        }

        public Strelka(int minPosition, int maxPosition)
        {
            MinPosition = minPosition;
            MaxPosition = maxPosition;
        }

        public void ChangePositionDrives(int minPosition, int maxPosition, string empty = "\0\0", string arrow = "->")
        {
            while (true)
            {
                ConsoleKeyInfo strelka = Console.ReadKey(true);
                switch (strelka.Key)
                {
                    case ConsoleKey.DownArrow:
                        if (_position < maxPosition)
                        {
                            Console.SetCursorPosition(0, _position);
                            Console.Write(empty);
                            Console.SetCursorPosition(0, ++_position);
                            Console.Write(arrow);
                            selected++;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (_position > minPosition)
                        {
                            Console.SetCursorPosition(0, _position);
                            Console.Write(empty);
                            Console.SetCursorPosition(0, --_position);
                            Console.Write(arrow);
                            selected--;
                        }

                        break;
                    case ConsoleKey.Enter:
                        Explorer.path += Explorer.DirList[selected];
                        Explorer.Catalogs(Explorer.path);
                        selected = -1;
                        break;
                }
            }
        }

        public void ChangePositionDir(int minPosition, int maxPosition, string empty = "\0\0", string arrow = "->")
        {
            while (true)
            {
                ConsoleKeyInfo strelka = Console.ReadKey(true);
                switch (strelka.Key)
                {
                    case ConsoleKey.DownArrow:
                        if (_position < maxPosition)
                        {
                            Console.SetCursorPosition(0, _position);
                            Console.Write(empty);
                            Console.SetCursorPosition(0, ++_position);
                            Console.Write(arrow);
                            selected++;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (_position > minPosition)
                        {
                            Console.SetCursorPosition(0, _position);
                            Console.Write(empty);
                            Console.SetCursorPosition(0, --_position);
                            Console.Write(arrow);
                            selected--;
                        }
                        break;
                    case ConsoleKey.Enter:

                        //string ext = Path.GetExtension(Explorer.files);

                        //if (ext != "")
                        //{
                        //    Explorer.path = "\\" + Explorer.dirs[selected];
                        //    Process.Start(new ProcessStartInfo { FileName = Explorer.path, UseShellExecute = true });
                        //}
                        //else
                        //{
                        //    Explorer.path += "\\" + Explorer.dirs[selected];
                        //    Explorer.Catalogs(Explorer.path);
                        //    selected = -1;
                        //}
                        try
                        {
                            Explorer.path += "\\" + Explorer.dirs[selected];
                            Explorer.Catalogs(Explorer.path);
                            oldsel = selected;
                            selected = -1;

                        }
                        catch
                        {
                            Explorer.path += "\\" + Explorer.files[oldsel];
                            string path = Path.GetFullPath(Explorer.path);
                            Process.Start(new ProcessStartInfo { FileName = path, UseShellExecute = true });
                            oldsel = -1;
                        }
                        break;
                        case ConsoleKey.Escape:
                        //if (Explorer.path.Length > 2)
                        //{
                        //    Explorer.Catalogs(cutLast(Path.GetFullPath(Explorer.path)));
                        //}
                        //else
                        //{
                        //    Console.Clear();
                        //    Explorer.path = " ";
                        //    Explorer.Drives();
                        //}
                        Console.Clear();
                        Program.Greetings();
                        Explorer.path = " ";
                        Explorer.Drives();
                        selected = -1;
                        break;
                }
            }
        }

        //public string cutLast(string v)
        //{
        //    selected = -1;
        //    int i = v.Length - 1;
        //    while (v[i] != '\\') i--;
        //    if (i > 0) return v.Substring(0, i + 1);
        //    return v;
        //}
    }
}
