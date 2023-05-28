using Microsoft.EntityFrameworkCore;
using System.Security.Policy;
using TemplaTask.DAL.Entities;

namespace TemplaTask.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contact { get; set; }
        public DbSet<Footer> Footer { get; set; }
        public DbSet<Downloads> Downloads { get; set; }
        public DbSet<SocialNetworks> SocialNetworks { get; set; }
    }
}
