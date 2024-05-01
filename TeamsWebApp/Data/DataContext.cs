using Microsoft.EntityFrameworkCore;
using TeamsWebApp.Models;

namespace TeamsWebApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
                
        }

        public DbSet<User> tbluser { get; set; }
        public DbSet<Message> tblDiscussion { get; set; }
    }
}
