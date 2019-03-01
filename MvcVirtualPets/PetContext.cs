using Microsoft.EntityFrameworkCore;
using MvcVirtualPets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcVirtualPets
{
    public class PetContext : DbContext
    {
        // Each type of Model that we track in the database must have a property like this one in
        // the Context.
        public DbSet<Pet> Pets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure our connection string (which db we are using) and some other optional things
            // like Proxies.
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=KM226Pets;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            // Microsoft wrote a default implementation of the OnConfiguring method and marked it virtual
            // so that we could customize it here.  When we override the method, it's important that
            // we still run the code in the original OnConfiguring method that MS wrote.  We do
            // that by running the base class' method, like so:
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // This is how we add "Seed Data" to our database.  What we write here will be picked up
            // the next time you Add-Migration.  When that new migration is applied to the DB with 
            // Update-Database it will create the specified records.
            // The models are the only time you'll really need to set IDs manually, usually the DB 
            // will handle it for you.
            modelBuilder.Entity<Pet>().HasData(
                new Pet() { Id = 1, Name = "Roscoe", Description = "Roscoe is a lazy old dog who loves to snuggle" },
                new Pet() { Id = 2, Name = "Biggs", Description = "Biggs is BIG because he eats whatever he finds"},
                new Pet() { Id = 3, Name = "Bella", Description = "Sweet Bella is so loyal and loving" }
                );

            // Similar to how OnConfiguring has a default implementation, so does OnModelCreating.
            // We run the default implementation below, after our custom implementation (above) has
            // completed.
            base.OnModelCreating(modelBuilder);
        }
    }
}
