using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Point
    {

        private int number1, number2;
        private string name;

        public int X 
        { 
         get { return number1; }
        }

        public int Y
        {
            get { return number2; }
        }


        public string Name
        {
            get { return name; }
        }



        public Point(int number1, int number2, string name)
        {
            this.number1 = number1;
            this.number2 = number2;
            this.name = name;
        }


    }
}
