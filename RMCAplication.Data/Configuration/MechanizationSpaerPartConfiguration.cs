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
    public class MechanizationSpaerPartConfiguration : IEntityTypeConfiguration<MechanizationSparePart>
    {
        public void Configure(EntityTypeBuilder<MechanizationSparePart> builder)
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            string path = Path.Combine(currentDirectory, "Datasets", "mechanizationSparePart.json");
            string data = File.ReadAllText(path);
            var consumable = JsonSerializer.Deserialize<List<MechanizationSparePart>>(data);

            if (consumable != null)
            {
                builder
                .HasData(consumable);
            }
        }
    }
}
