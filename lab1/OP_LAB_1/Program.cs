using System;

namespace OP_LAB_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Squar Kvadrat0=new Squar(new Point(1,1),new Point(5,5));


            Console.WriteLine(Kvadrat0.Perimetr());
        }
    }
}