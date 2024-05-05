using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi4._0.Domain.Models
{
    public class Taxi2 : DbContext
    {
        public DbSet <User> Users { get; set; }
        public DbSet <Account> Accounts { get; set; }
        public DbSet <Order> Orders { get; set; }
        public DbSet <Location> Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().OwnsOne(a => a.RideTime);
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;port=3306;username=root;password=1590;database=taxi2",
                new MySqlServerVersion(new Version(8, 0, 11)));

            base.OnConfiguring(optionsBuilder);
        }
    }
}
