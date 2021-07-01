using IssueTracker.API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace IssueTracker.API.Data.DataContexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<AppUser> Users { get; set; }
    }
}