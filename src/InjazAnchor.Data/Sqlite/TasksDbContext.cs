using Microsoft.EntityFrameworkCore;

namespace InjazAnchor.Data.Sqlite
{
    public class TasksDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=data/injaz.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly, 
                x => string.IsNullOrEmpty(x.Namespace) && x.Namespace.StartsWith("InjazAnchor.Data.Sqlite.Mappings"));
        }
    }
}