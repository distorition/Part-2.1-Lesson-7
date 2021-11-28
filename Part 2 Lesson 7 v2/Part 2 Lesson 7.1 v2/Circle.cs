using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_Lesson_6._2
{
    public class Circle
    {
        public void MakeCircle(int centerX,int centerY,int radius )
        {
            Action<int, int> write = (xp, yp) => { Console.SetCursorPosition(xp, yp); Console.Write("*"); };
            int xss;
            int  x = -radius;
            while (x < radius)
            {
                var y = (int)Math.Floor(Math.Sqrt(radius * radius - x * x));

                write(x + centerX, y + centerY);
                y = -y;
                write(x + centerX, y + centerY);
                x++;
            }
            Console.ReadLine();
        }
        public void MakeCircle()
        {
            Action<int, int> write = (xp, yp) => { Console.SetCursorPosition(xp, yp); Console.Write("*"); };

            int centerX = 20, centerY = 10, radius = 8, x = -radius;
            while (x < radius)
            {
                var y = (int)Math.Floor(Math.Sqrt(radius * radius - x * x));

                write(x + centerX, y + centerY);
                y = -y;
                write(x + centerX, y + centerY);
                x++;
            }
            Console.ReadLine();
        }
    }
}
