using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Loading_DataAnnotations_Examples
{
    public class AppDbContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Blog>().HasData(
                new Blog() { BlogId = 1, BlogName = "GökçeBlog"},
                new Blog() { BlogId = 2, BlogName = "MelisBlog" }
                );
            modelBuilder.Entity<Post>().HasData(
                new Post() { PostId = 1, Title = "C# nedir?", BlogId = 2},
                new Post() { PostId = 2, Title = "Front-End nedir?", BlogId = 1 },
                new Post() { PostId = 3, Title = "Back-End nedir?", BlogId = 2 },
                new Post() { PostId = 4, Title = "API nedir?", BlogId = 1 }
                );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=.;database=YZL8101EFCoreIntro3;uid=sa;pwd=1234;trustservercertificate=true;");
        }
    }
}
