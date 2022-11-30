using System;
using System.Collections.Generic;
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

        public Strelka()
        {
            
        }
        public Strelka(int minPosition, int maxPosition)
        {
            MinPosition = minPosition;
            MaxPosition = maxPosition;
        }
        public void ChangePosition(int minPosition, int maxPosition, string empty = "\0\0", string arrow = "->")
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
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (_position > minPosition)
                        {
                            Console.SetCursorPosition(0, _position);
                            Console.Write(empty);
                            Console.SetCursorPosition(0, --_position);
                            Console.Write(arrow);
                        }
                        break;
                    case ConsoleKey.Escape:

                        break;
                    case ConsoleKey.Enter:
                        if (_position == 3)
                        {
                            Explorer.Catalogs(_position = 0);
                        }

                        if (_position == 4)
                        {
                            Explorer.Catalogs(_position = 1);
                        }

                        if (_position == 5)
                        {
                            Explorer.Catalogs(_position = 2);
                        }

                        _position = 2;

                        break;
                }
            }
        }
    }
}
