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
    public class SparePartConfiguration : IEntityTypeConfiguration<SparePart>
    {
        public void Configure(EntityTypeBuilder<SparePart> builder)
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            string path = Path.Combine(currentDirectory, "Datasets", "SparePart.json");
            string data = File.ReadAllText(path);
            var consumable = JsonSerializer.Deserialize<List<SparePart>>(data);

            if (consumable != null)
            {
                builder
                .HasData(consumable);
            }
        }
    }
}
