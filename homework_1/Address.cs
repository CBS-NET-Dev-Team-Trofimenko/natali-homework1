using System;
using System.Collections.Generic;
using System.Text;

namespace homework_1
{
    class Address
    {
        private int index ;
        private string country;
        private string city;
        private string street;
        private int house;
        private int apartment;

        public int Index
        {
            set
            {
                if (value < 1) {
                    Console.WriteLine("Error");
                }
                else
                {
                    index = value;
                }
            }
            get
            {
               
                return index;
            }
        }

        public string Country
        {
            set
            {
             
                    country = value;
                
            }
            get
            {
                if(country == null)
                {
                    return "Error";
                }
                return country;
            }
        }

        public string City
        {
            set
            {
             
                    city = value;
                
            }
            get
            {

                if (city == null)
                {
                    return "Error";
                }
                return city;
            }
        }

        public string Street
        {
            set
            {
              
                    street = value;
                
            }
            get
            {

                if (street == null)
                {
                    return "Error";
                }
                return street;
            }
        }

        public int House
        {
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Error");
                }
                else
                {
                   house = value;
                }
            }
            get
            {

                return house;
            }
        }

        public int Apartment
        {
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    apartment = value;
                }
            }
            get
            {

                return apartment;
            }
        }


    }
}
