
using Microsoft.EntityFrameworkCore;
using ProjectWithBlazor.Domain.Entities;

namespace ProjectWithBlazor.Infrastructure.Context
{
    public class ProjectWithBlazorDbContext :DbContext
    {
        public ProjectWithBlazorDbContext(DbContextOptions<ProjectWithBlazorDbContext> options) : base(options)
        {
            
        }

        public DbSet<Book> Books { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Book>().Property(e => e.Title).IsRequired().HasMaxLength(100);
        //    modelBuilder.Entity<Book>().Property(e => e.Author).IsRequired().HasMaxLength(100);
        //}
    }
}
