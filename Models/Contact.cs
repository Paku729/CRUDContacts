using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDContacts.Models
{
    public class Contact
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public int MobilePhone{ get; set; }       
        public string JobTitle { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
