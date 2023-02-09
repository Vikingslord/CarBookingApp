using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookingApp.Data.Data
{
    public class CarDbContextFactory : IDesignTimeDbContextFactory<CarBookDbContext>
    {
        public CarBookDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CarBookDbContext>();
            optionsBuilder.UseSqlServer("Data Source=Anonymous;Initial Catalog=CarBook;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            return new CarBookDbContext(optionsBuilder.Options);
        }
    }
}
