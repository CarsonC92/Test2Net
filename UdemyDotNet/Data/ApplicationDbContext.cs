using Microsoft.EntityFrameworkCore;
using UdemyDotNet.Model;

namespace UdemyDotNet.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Category { get; set; } 
    }
}
