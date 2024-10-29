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
    public class ConsumableConfiguration : IEntityTypeConfiguration<Consumable>
    {
        public void Configure(EntityTypeBuilder<Consumable> builder)
        {
            string path = Path.Combine(AppContext.BaseDirectory, "Data", "Datasets", "consumable.json");
            string data = File.ReadAllText(path);
            var consumable = JsonSerializer.Deserialize<List<Consumable>>(data);

            if (consumable != null)
            {
                builder
                .HasData(consumable);
            }
        }
    }
}
