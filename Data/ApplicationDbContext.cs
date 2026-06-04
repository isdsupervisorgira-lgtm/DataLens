using Microsoft.EntityFrameworkCore;
using DataLens.Models;
namespace DataLens.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<AQIData> AQIHourlyData { get; set; }
    }

}
