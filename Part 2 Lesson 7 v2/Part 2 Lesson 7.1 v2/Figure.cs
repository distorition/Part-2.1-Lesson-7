using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_Lesson_6._2
{
   public class Figure
    {
        public string Collor { get; set; }
        public bool Seting { get; set; }
        private int X { get; set; }
        private int Y { get; set; }

        public Figure(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void MakeFigure()
        {
            for (int i = 0; i < Y; i++)
            {
                for (int g = 0; g < X; g++)
                {
                    Console.Write("&");
                }
                Console.WriteLine();
            }
        }
        public void MakeFigure(int xmove,int ymove)
        {
                Console.Write(" ");
                for (int f = 0; f < ymove; f++)
                {

                    for (int t = 0; t < xmove; t++)
                    {
                        Console.Write(" ");
                    if(t==(X-1))
                    {
                        for (int i = 0; i < Y; i++)
                        {
                            Console.Write("^");
                        }
                    }
                    }
                    Console.WriteLine(" ");
                }
        }

        public void MakeFigure( int ymove)
        {
            Console.Write(" ");
            for (int f = 0; f < ymove; f++)
            {             
                    Console.Write(" ");
                    if (f == (X - 1))
                    {
                    MakeFigure();
                    }
                
                Console.WriteLine(" ");
            }
        }

        public void MakeTreangle()
        {
            for (int i = 0; i < X; i++)
            {
                for (int g = 0; g < i; g++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
        public virtual void Indicate(bool turningLeft)
        {
            Seting = turningLeft;
            if (Seting)
                Console.WriteLine("Active");
            else
                Console.WriteLine("Unactive");
        }
        public virtual void Show()
        {
            Console.WriteLine(string.Join(",",Collor));
        }

    }
}
