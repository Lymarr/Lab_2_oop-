using lab_2_1_oop;
using System;

namespace lab_2_oop
{
    class task_1
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Index = 39482;
            Address address1 = new Address();
            address.Index = 84125;
            address.Country = "Ukraine";
            address.City = "Kyiv";
            address.Street = "Ambulatorna";
            address.House = 231;
            address.Apartment = 45;
            Console.WriteLine("You live in:");
            Console.WriteLine(address.Index);
            Console.WriteLine(address.Country);
            Console.WriteLine(address.City);
            Console.WriteLine(address.Street);
            Console.WriteLine(address.House);
            Console.WriteLine(address.Apartment);
            Console.ReadKey();
        }


    }
}
