using System;

namespace homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Address addres = new Address();
            addres.Index = 67;
            addres.Country = "Ukrain";
            addres.City = "Kharkiv";
            addres.Street = "Sumskaya";
            addres.House = 89;
            addres.Apartment = 6;
            Console.WriteLine("index == {0}, country == {1}, city == {2}, street == {3}, house == {4}, apartment == {5}" , addres.Index , addres.Country, addres.City, addres.Street, addres.House, addres.Apartment);
        }
    }
}
