namespace InjazAnchor.Data.Entities.Tasks
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public int TopTaskId { get; set; }

        public int ParentTaskId { get; set; }
    }
}