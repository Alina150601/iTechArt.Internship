using System;
using Microsoft.EntityFrameworkCore;

namespace phonebook
{
    public class PhonebookContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user=root;password=1111;database=phonebook;",
                new MySqlServerVersion(new Version(8,0,11)));
        }
    }
}
