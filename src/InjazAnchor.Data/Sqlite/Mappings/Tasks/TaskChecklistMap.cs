using InjazAnchor.Data.Entities.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InjazAnchor.Data.Sqlite.Mappings.Tasks
{
    public class TaskChecklistMap : IEntityTypeConfiguration<TaskChecklist>
    {
        public void Configure(EntityTypeBuilder<TaskChecklist> builder)
        {
            builder.HasKey(c => c.Id);
            builder.ToTable("TaskChecklists");
        }
    }
}