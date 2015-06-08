using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact
{
    class Program
    {
        static void Main(string[] args)
        {

            Contact c = new Contact();
            c.Id = 1;
            c.FirstName = "John";
            c.LastName = "Doe";

            c.Phones.Add(new Phone { Number = "+1-(409)586-8494", Type = "Home" });
            c.Phones.Add(new Phone { Number = "+1(510)847-0495", Type = "Personal" });

            c.Addresses.Add(new Address { Id = 1, Street = "1 Microsoft Way", City = "Redmond", State = "Washington", ZipCode = "59697", Country = "USA" });
            c.Addresses.Add(new Address { Id = 2, Street = "1 Google Way", City = "San Jose", State = "California", ZipCode = "90758", Country = "USA" });

            Console.WriteLine(c.Id);
            Console.WriteLine(c.FirstName);
            Console.WriteLine(c.LastName);

            foreach (Phone p in c.Phones)
            {
                Console.WriteLine(string.Concat(p.Type, " - ", p.Number));
            }

            foreach(Address a in c.Addresses)
            {
                Console.WriteLine(string.Concat(a.Id, ": " , a.Street , Environment.NewLine, a.City, Environment.NewLine, a.State));
            }

            Console.ReadKey();
        }
    }
}
