using Microsoft.EntityFrameworkCore;
using WorkCards.Infrastructure.DAL.Models;
using Microsoft.Extensions.Configuration;
using WorkCards.Configuration;

namespace WorkCards.Infrastructure.DAL.FE
{
    public class WorkCardsContext : DbContext
    {
       
        public DbSet<Card> Cards { get; set; }
        public DbSet<WorkCard> WorkCards { get; set; }
        public DbSet<User> Users { get; set; }

        public WorkCardsContext(DbContextOptions<WorkCardsContext> options)
           : base(options)
        {
           
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(Configurations.GetSection("ConnectionStrings"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>().ToTable("Card");
            modelBuilder.Entity<WorkCard>().ToTable("WorkCard");
            modelBuilder.Entity<User>().ToTable("User");
            base.OnModelCreating(modelBuilder);
        }
    }
}
