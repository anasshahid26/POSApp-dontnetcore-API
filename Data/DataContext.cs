using POSApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace POSApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>  options) : base (options) {}

        public DbSet<Value> Values { get; set; }
        public DbSet <user> Users { get; set; }
        public DbSet<Items> Items { get; set; }
    }
}