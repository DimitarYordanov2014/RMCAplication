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
    internal class MechanisationConsumableConfiguration : IEntityTypeConfiguration<MechanizationConsumable>
    {
        public void Configure(EntityTypeBuilder<MechanizationConsumable> builder)
        {
            string path = Path.Combine(AppContext.BaseDirectory, "Datasets", "mechanizationConsumable.json");
            string data = File.ReadAllText(path);
            var consumable = JsonSerializer.Deserialize<List<MechanizationConsumable>>(data);

            if (consumable != null)
            {
                builder
                .HasData(consumable);
            }
        }
    }
}
