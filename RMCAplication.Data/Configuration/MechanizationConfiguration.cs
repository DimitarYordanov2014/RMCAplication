using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMCAplication.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RMCAplication.Data.Configuration
{
    public class MechanizationConfiguration : IEntityTypeConfiguration<Mechanization>
    {
        public void Configure(EntityTypeBuilder<Mechanization> builder)
        {
            string path = Path.Combine(AppContext.BaseDirectory, "Datasets", "mechanization.json");
            string data = File.ReadAllText(path);
            var consumable = JsonSerializer.Deserialize<List<Mechanization>>(data);

            if (consumable != null)
            {
                builder
                .HasData(consumable);
            }
        }
    }
}
