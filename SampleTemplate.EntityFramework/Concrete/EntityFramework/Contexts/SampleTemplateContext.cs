using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SampleTemplate.Entities.Domain;

namespace SampleTemplate.EntityFramework.Contexts
{
    public class SampleTemplateContext : IdentityDbContext<User, Role, int, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Category> Categories { get; set; }
       
        public SampleTemplateContext(DbContextOptions<SampleTemplateContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserLogin>().HasKey(b => b.UserId);
            modelBuilder.Entity<UserRole>().HasKey(b => b.UserId);
            modelBuilder.Entity<UserToken>().HasKey(b => b.UserId);

            modelBuilder.ApplyConfiguration(new TicketConfiguration());           
        }

    }
}
