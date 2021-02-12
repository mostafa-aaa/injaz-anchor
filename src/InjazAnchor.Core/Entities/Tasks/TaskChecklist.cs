namespace InjazAnchor.Core.Entities.Tasks
{
    public class TaskChecklist : BaseEntity
    {
        public int TaskId { get; set; }

        public string Description { get; set; }

        public bool Done { get; set; }
    }
}