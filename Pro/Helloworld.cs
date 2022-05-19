using System;
using System.Threading;

namespace Pro
{
    class Helloworld
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            /*
            int x = 1;
            while (x < 50)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 5);
                //출력
                if (x % 3 == 0)
                    Console.WriteLine("__@");
                else if (x % 3 == 1)
                {
                    Console.WriteLine("__^@");
                }
                else 
                { 
                    Console.WriteLine("^__@");
                    Thread.Sleep(1000);
                }
            }

            bool isRun = true;
            while (isRun)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                switch (info.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("위로 이동"); break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("아래로 이동"); break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("왼으로 이동"); break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("오른으로 이동"); break;
                    case ConsoleKey.Escape:
                        Console.WriteLine("종료!"); isRun = false;  break;
                }
            }*/

            Random random = new Random();
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));

            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble()*10);

        }
    }
}
