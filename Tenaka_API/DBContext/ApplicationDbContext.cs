
using Microsoft.EntityFrameworkCore;
using Tenaka_API.Model;
namespace Tenaka_API.DBContext
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<user> user { get; set; }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Configure middleware, routing, etc.
        }
    }
}
