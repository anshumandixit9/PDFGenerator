using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PDFGenerator.Models;

namespace PDFGenerator.Data
{
    public class DataContext: DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }
        public DbSet<SampleModel> samplemodel { get; set; }
    }
}
