using System;

namespace Part_2_Lesson_7_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Acodet acodet = new Acodet();
             acodet.Encode("bb");
            Console.WriteLine(acodet.sas);
            acodet.Decode("aa");
            Console.WriteLine(acodet.revs);

        }
    }
}
