using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MessageBoard.Models;

namespace MessageBoard.Data
{
    public class BoardDbContext : IdentityDbContext<BoardUser>
    {
        public BoardDbContext()
        {

        }
        public BoardDbContext(DbContextOptions<BoardDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnectionString");
            optionsBuilder.UseNpgsql(connectionString);
        }

        public DbSet<Message> Messages { get; set; }

    }
}
