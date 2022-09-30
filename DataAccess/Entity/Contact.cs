using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Contact
    {
        public int ID { get; set; }
        public string Address { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string MapLocation { get; set; }
        public bool Status { get; set; }
    }
}
