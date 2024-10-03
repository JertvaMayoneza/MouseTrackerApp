using Microsoft.EntityFrameworkCore;

namespace MouseTrakerApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<MouseMovement> MouseMovements { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MouseMovement>().ToTable("MouseMovements");
        }
    }
    public class MouseData
    {
        public int X { get; set; }
        public int Y { get; set; }
        public long T { get; set; }
    }
}
