using BaoHongAcademy.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BaoHongAcademy.Infrastructure
{
    public class BaoHongContext : DbContext
    {
        public BaoHongContext(DbContextOptions<BaoHongContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Course");
        }
    }
}
