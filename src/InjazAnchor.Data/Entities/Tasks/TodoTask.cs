using System;

namespace InjazAnchor.Data.Entities.Tasks
{
    public class TodoTask : BaseEntity
    {
        public int CategoryId { get; set; }

        public int TopTaskId { get; set; }

        public int ParentTaskId { get; set; }

        public string Title { get; set; }

        public string Details { get; set; }

        public byte Importance { get; set; }

        public int PlannedDuration_SEC { get; set; }

        public DateTime CreatedOn { get; set; }


        public TaskStatus Status { get; set; }

        public DateTime StartedOn { get; set; }

        public DateTime EndedOn { get; set; }

        public int CompletionDuration_SEC { get; set; }
    }
}