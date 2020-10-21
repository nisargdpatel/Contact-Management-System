using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactManagemenSystem.Data
{
    public class ContactDatabase:DbContext
    {
        public ContactDatabase(DbContextOptions<ContactDatabase> options):base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
