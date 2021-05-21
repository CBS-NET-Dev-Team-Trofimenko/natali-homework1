using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Figure
    {
         

        private Point p1;
        private Point p2;
        private Point p3;
        private Point p4;
        private Point p5;
        private double permiter;

        public Figure(Point p1, Point p2, Point p3) : this(p1,p2,p3,p3,p3)
        {
            

      

        }
        public Figure(Point p1, Point p2, Point p3, Point p4) : this(p1, p2, p3, p4, p4)
        {
       
        

        }
        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5) 
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;  
            this.p4 = p4;
            this.p5 = p5;

        }




        public double LengthSide(Point number1, Point number2)
        {
            return Math.Sqrt(Math.Pow((number1.Y - number2.Y), 2) + Math.Pow((number1.X - number2.X), 2));
        }
        void PerimeterCalculator()
        {
            double len =0;
            len = LengthSide(p1, p2);
            len += LengthSide(p2, p3);
            len += LengthSide(p3, p4);
            len += LengthSide(p4, p5);
            len += LengthSide(p5, p1);
            permiter = len;
        }
  

        public double Perimeter
        {
            get
            {
                PerimeterCalculator();
                return permiter;
            }
        }

    }
}
