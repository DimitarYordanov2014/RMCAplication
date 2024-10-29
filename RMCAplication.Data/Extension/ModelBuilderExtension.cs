using Microsoft.EntityFrameworkCore;
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
            modelBuilder.ApplyConfiguration(new ConsumableConfiguration());
            //modelBuilder.ApplyConfiguration(new HallConfiguration());
            //modelBuilder.ApplyConfiguration(new CinemaHallsConfiguration());
            //modelBuilder.ApplyConfiguration(new MovieConfiguration());
            //modelBuilder.ApplyConfiguration(new ScheduleConfiguration());
            //modelBuilder.ApplyConfiguration(new UserConfiguration());
            //modelBuilder.ApplyConfiguration(new SeatConfiguration());
            //modelBuilder.ApplyConfiguration(new TariffConfiguration());
            //modelBuilder.ApplyConfiguration(new TicketConfiguration());
        }
    }
}
