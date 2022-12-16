using Microsoft.EntityFrameworkCore;

namespace PracticeTRPO
{
    class ApplicationContext : DbContext
    {

        public DbSet<Employer> Employers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=MyDB.db");
        }

    }
}
