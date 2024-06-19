using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_2_CSharp
{
    public class Contact
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Contact(int id, string name, string phone, string email)
        {
            ID = id;
            Name = name;
            Phone = phone;
            Email = email;
        }
    }

}
