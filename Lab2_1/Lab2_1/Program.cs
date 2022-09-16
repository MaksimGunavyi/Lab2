using System;

namespace Lab2_1
{
    class Address
    {
        public string Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }

    }
    class Program
    {
        static void Main()
        {
            Address address = new Address
            {
                Index = "87500",
                Country = "Ukraine",
                City = "Mariupol",
                Street = "Moskovskaya street",
                House = "63",
                Apartment = "89"
            };

            Console.WriteLine($"Index: {address.Index}");
            Console.WriteLine($"Country: {address.Country}");
            Console.WriteLine($"City: {address.City}");
            Console.WriteLine($"Street: {address.Street}");
            Console.WriteLine($"House: {address.House}");
            Console.WriteLine($"Apartment: {address.Apartment}");

            Console.ReadKey();
        }
    }
}