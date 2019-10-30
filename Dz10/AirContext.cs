using Dz10.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dz10
{
    public class AirContext : DbContext
    {
        public AirContext()
        {
            Database.Migrate();
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Airplane> Airplanes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=A-305-12;Database=AirDb;Trusted_Connection=true;");
        }
    }
}
