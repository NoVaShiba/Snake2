using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            
            //отрисовка рамки
            HorisontalLines Upline = new HorisontalLines(0, 78 , 0, '+');
            HorisontalLines Downline = new HorisontalLines(0, 78, 24, '+');
            VerticalLine Leftline = new VerticalLine(0, 24, 0, '+');
            VerticalLine Rightline = new VerticalLine(0, 24, 78, '+');
            Upline.Draw();
            Downline.Draw();
            Leftline.Draw();
            Rightline.Draw();

            //отрисовака точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            
            while(true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Handlkey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }
        }
    }
}
