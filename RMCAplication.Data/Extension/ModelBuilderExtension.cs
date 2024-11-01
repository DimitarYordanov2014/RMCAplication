﻿using Microsoft.EntityFrameworkCore;
using RMCAplication.Data.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace RMCAplication.Data.Models.Extension
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MechanizationConfiguration());
            modelBuilder.ApplyConfiguration(new WarehouseConfiguration());
            modelBuilder.ApplyConfiguration(new ConsumableConfiguration());           
            modelBuilder.ApplyConfiguration(new PersonConfiguration());
            modelBuilder.ApplyConfiguration(new ToolConfiguration());
            modelBuilder.ApplyConfiguration(new SparePartConfiguration());
            modelBuilder.ApplyConfiguration(new MechanisationConsumableConfiguration());
            modelBuilder.ApplyConfiguration(new MechanizationSpaerPartConfiguration());
        }
    }
}
