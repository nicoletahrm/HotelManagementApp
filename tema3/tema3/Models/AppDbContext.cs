using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tema3.Models;
using tema3.Models.Entity;

namespace tema3
{
    public class AppDbContext : DbContext
    {
        string connectionString = "Data Source=NICOPC;Initial Catalog=Tema3;Trusted_Connection=True;";

        public AppDbContext() : base() { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<Offer> Offer { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<Facility> Facilitiy { get; set; }
        public DbSet<Image> Image { get; set; }
        //public DbSet<RoomOffer> RoomOffer { get; set; }
        //public DbSet<RoomFacility> RoomFacility { get; set; }
        //public DbSet<RoomImage> RoomImage { get; set; }
        //public DbSet<ReservationRoom> ReservationRoom { get; set; }
        //public DbSet<ReservationService> ReservationService { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
