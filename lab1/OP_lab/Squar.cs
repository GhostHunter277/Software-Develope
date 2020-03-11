using System;
namespace OP_LAB_1

{/// <summary>
 /// Square class with objects
 /// </summary>
    public class Squar
    {
        public Point a;
        public Point b;
        public Colour z;
        
        /// <summary>
        /// Constructor Square
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public Squar(Point a, Point b)
        {
            this.a = a;
            this.b = b;
        }
/// <summary>
/// Check squar 
/// </summary>
/// <returns></returns>
        public bool checkSquar()
        {
            if (a.x - b.x == a.y - b.y)
                return true;
            else return false;
        }
/// <summary>
/// Upper point search
/// </summary>
/// <returns></returns>
        public Point UpperPoint()
        {
            Point Upper= new Point(a.x,b.y);
            return Upper;
        }
/// <summary>
/// lower point search
/// </summary>
/// <returns></returns>
        public Point LowerPoint()
        {
            Point Lower= new Point(b.x,a.y);
            return Lower;
        }
/// <summary>
/// search Area of Square
/// </summary>
/// <returns></returns>
        public int Area()
        {
            int area = (UpperPoint().y - a.y) * (UpperPoint().y - a.y);
            return area;
        }
/// <summary>
/// search perimeter of square
/// </summary>
/// <returns></returns>
        public int Perimetr()
        {
            int perimetr = 4 * (UpperPoint().y - a.y);
            return perimetr;
        }
/// <summary>
/// Set blue colour
/// </summary>

        public void SetBlue()
        {
            z.colour = "blue";
        }
        /// <summary>
        /// set red colour
        /// </summary>
        public void SetRed()
        {
            z.colour = "red";
        }
/// <summary>
/// Actual Time
/// </summary>
        public void ReturnTime()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString("F"));
        }
        /// <summary>
        /// set Alpha of colour
        /// </summary>
        public void SetAlpha()
        {
            z.Alpha = "50%";
        }
/// <summary>
/// print info
/// </summary>
        public void Print()
        {
            Console.WriteLine("Final"+Area());
        }
        
        
        
        
        
    }
}