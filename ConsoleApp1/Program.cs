using System;
using System.Threading;

namespace ConsoleApp1
{
    internal class Program
    {
        struct HorseInfo
        {
            public int left;
            public int top;
            public ConsoleColor color;
        }
        static void Main(string[] args)
        {
            do
            {
                const string horse_symbol = ")))";
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                #region Draw lines 
                for (int i = 1; i < Console.WindowWidth; i++)
                {
                    for (int j = 0; j < Console.WindowHeight; j += 2)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write("=");
                    }
                }
                #endregion

                #region Set positions
                Random rnd = new Random();
                int horses = Convert.ToInt32(Console.WindowHeight / 2) - 1;
                HorseInfo[] coords = new HorseInfo[horses];
                for (int top = 1, i = 0; top < Console.WindowHeight - 1; top += 2, i++)
                {
                    Console.SetCursorPosition(1, top);
                    Console.ForegroundColor = (ConsoleColor)rnd.Next((int)ConsoleColor.DarkBlue, (int)ConsoleColor.White);
                    Console.Write(horse_symbol);
                    coords[i].left = 1;
                    coords[i].top = top;
                    coords[i].color = Console.ForegroundColor;
                }
                #endregion

                int winner = -1;
                #region Run
                while (true)
                {
                    int h = rnd.Next(0, horses);

                    Console.SetCursorPosition(coords[h].left, coords[h].top);
                    Console.Write(" ");
                    coords[h].left++;
                    Console.ForegroundColor = coords[h].color;
                    Console.Write(horse_symbol);

                    if (coords[h].left == Console.WindowWidth - 3)
                    {
                        winner = h;
                        break;
                    }
                    Thread.Sleep(200);
                }
                #endregion
                #region Show winner
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
                Console.Write("Winner is {0} !!", winner + 1);
                
                #endregion
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
