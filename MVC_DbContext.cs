using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDContacts.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDContacts
{
    public class MVC_DbContext : DbContext
    {
        public MVC_DbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set;  }
    }
}
