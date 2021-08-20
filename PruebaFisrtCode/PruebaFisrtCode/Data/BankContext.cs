using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PruebaFisrtCode.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaFisrtCode.Data
{
    public class BankContext : DbContext
    {
        public BankContext(DbContextOptions<BankContext> options)
            : base(options)
        {
        }

        public DbSet<Clients> Clients { get; set; }
        public DbSet<Bills> Bills { get; set; }
        public DbSet<Transfers> Transfers { get; set; }

        public DbSet<Users> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clients>().ToTable("Clients");
            modelBuilder.Entity<Bills>().ToTable("Bills");
            modelBuilder.Entity<Transfers>().ToTable("Transfers");
            modelBuilder.Entity<Users>().ToTable("Users");
        }
    }


}
