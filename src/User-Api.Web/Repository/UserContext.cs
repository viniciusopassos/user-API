using Microsoft.EntityFrameworkCore;
using User_Api.Web.Models;

namespace User_Api.Web.Repository
{
    public class UserContext : DbContext
    {
        public UserContext() {}

        public UserContext(DbContextOptions<UserContext> options) : base(options){}

        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=localhost;Database=User_db;User=SA;Password=Password12!;TrustServerCertificate=True");
            }
        }
    }
}