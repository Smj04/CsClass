using System;
using System.Collections.Generic;
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
            Console.WriteLine(random.NextDouble() * 10);

            List<int> list = new List<int>();
            list.Add(52);
            list.Add(273);
            list.Add(32);
            list.Add(64);

            foreach (var item in list)
            {
                Console.WriteLine("Count : " + list.Count + "item:" + item);
            }

            Hamburger nyam = new Hamburger();

            Product productA = new Product() { name = "소금빵", price = 2000 };
            productA.name = "포켓몬빵";
            Product productB = new Product() { price = 5500, name = "당근케이크" };
            Product productC = new Product() { name = "보름달" };

            Box1 box1 = new Box1(10, 10);
            box1.width = -10;
            Console.WriteLine("box1의 면적 : " + box1.Area());

            Box2 box2 = new Box2(10, 10);
            box2.setWidth(-10);
            Console.WriteLine("box2의 면적 : " + box2.Area());

            Box box = new Box(10, 10);
            box.Width = -10;
            Console.WriteLine("box의 면적 : " + box.Area);

        }
    }
}
