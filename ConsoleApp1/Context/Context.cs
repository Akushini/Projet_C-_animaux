using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;
using ConsoleApp1.Service;

namespace ConsoleApp1.Context
{
    public class Context : DbContext
    {
        public Context() 
        {
          
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-K9GHE7AE;Initial Catalog=test;Integrated Security=True; Encrypt=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

        public DbSet<Dragon> Dragon { get; set; }
        public DbSet<Dog> Dog { get; set; }

    }
}
