using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace aspnetcoreapp.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Person> People {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MyDb");

        }


    }
}