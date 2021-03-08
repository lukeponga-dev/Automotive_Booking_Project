using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Automotive_Booking_Project.Models;

namespace Automotive_Booking_Project.Data
{
    public class Automotive_Booking_ProjectContext : DbContext
    {
        public Automotive_Booking_ProjectContext (DbContextOptions<Automotive_Booking_ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Automotive_Booking_Project.Models.Users> Users { get; set; }

        public DbSet<Automotive_Booking_Project.Models.bookings> bookings { get; set; }
    }
}
