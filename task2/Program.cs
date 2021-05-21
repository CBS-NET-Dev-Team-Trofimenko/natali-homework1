using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(20,30);
            Console.WriteLine("Area == {0}, Perimeter == {1}", rectangle.Area, rectangle.Perimeter);
        }
    }
}
