using Microsoft.EntityFrameworkCore;
using WebProject.Models;

namespace WebProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        } public DbSet<Category> Catagories { get; set; }
        
            protected override void OnModelCreating(ModelBuilder modelBuilder) {


            modelBuilder.Entity<Category>().HasData(
            new Category { id = 1, name = "Messi", DisplayOrder = 1 },
            new Category { id = 2, name = "Ronaldo", DisplayOrder = 2 },
              new Category { id = 3, name = "goat", DisplayOrder = 3 }

            );

        }
        
    }
}
