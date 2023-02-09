using CarBookingApp.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace CarBookingApp.Data.Data
{
    public class CarBookDbContext : DbContext //Represents Database
    {
        public CarBookDbContext(DbContextOptions<CarBookDbContext> options) : base(options)
        { 

        }
         
        public DbSet<Car> Cars { get; set; }  // Database Table

    }  
}
