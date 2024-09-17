using System.Drawing;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            snail s = new snail(50,0,10);
            snail s1 = new snail(50, 0, 15);
            while (true)
            {
                s.show();
                s.Move();
                s1.pause();
                s1.show();
                s.pause();
                s1.Move();

            }
        }
        class snail
        {
            int pv;
            int x;
            int y;
            public snail(int pl, int coordoneex, int coordoneey)
            {
                pv = pl;
                x = coordoneex;
                y = coordoneey;
            }
            public void show()
            {
                Console.SetCursorPosition(x, y);
                if (pv == 0)
                {
                    Console.WriteLine("____");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("_@_ö");
                }
            }
            public void Move()
            {
               pv--;
               x++;
               Thread.Sleep(100);
            }
            public void hide()
            {
                Console.Clear();
            }
            public void pause()
            {
                for (int i = 0; i < 2; i++)
                {
                    Random rand = new Random();
                    if (rand.Next(1, 30) == 1)
                        Thread.Sleep(1000);
                }
            }
        }
         
        
    }
}
