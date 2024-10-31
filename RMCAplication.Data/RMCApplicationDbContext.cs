using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RMCAplication.Data.Models;
using RMCAplication.Data.Models.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMCAplication.Data
{
    public class RMCApplicationDbContext : IdentityDbContext
    {
        public RMCApplicationDbContext(DbContextOptions<RMCApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MechanizationConsumable>()
                .HasKey(c => new { c.MechanizationId, c.ConsumableId });
            modelBuilder.Entity<MechanizationSparePart>()
                .HasKey(x => new { x.MechanizationId, x.SparePartId });

            modelBuilder.Seed();

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Warehouse> Consumables { get; set; }
        public DbSet<Mechanization> Mechanizations { get; set; }
        public DbSet<MechanizationConsumable> MechanizationConsumables { get; set; }
        public DbSet<MechanizationSparePart> MechanizationSpareParts { get; set; }
        public DbSet<SparePart> SpareParts { get; set; }
        public DbSet<Tool> Tools { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
    }
}
