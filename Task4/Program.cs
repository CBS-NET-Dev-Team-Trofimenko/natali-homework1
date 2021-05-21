using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
     
            Figure figure = new Figure(new Point(1,1,""), new Point(2,3,""), new Point(3,3,""));
            Console.WriteLine(figure.Perimeter);

            figure = new Figure(new Point(1, 1, ""), new Point(2, 1, ""), new Point(2, 0, ""), new Point(1,0,""));
            Console.WriteLine(figure.Perimeter);
        }
    }
}
