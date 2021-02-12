using InjazAnchor.Core.Entities.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InjazAnchor.Data.Sqlite.Mappings.Tasks
{
    public class TodoTaskMap : IEntityTypeConfiguration<TodoTask>
    {
        public void Configure(EntityTypeBuilder<TodoTask> builder)
        {
            builder.HasKey(c => c.Id);
            builder.ToTable("Tasks");
        }
    }
}