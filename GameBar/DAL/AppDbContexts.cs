using GameBar.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GameBar.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<TrendingGame>Games { get; set; }
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<TrendingGame>GameBar {  get; set; }
    }
}
