using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Phones Phones;

        public Addresses Addresses;

        public Contact()
        {
            Phones = new Phones();
            Addresses = new Addresses();
        }
    }
}
