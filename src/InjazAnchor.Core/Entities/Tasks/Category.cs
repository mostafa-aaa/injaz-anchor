﻿namespace InjazAnchor.Core.Entities.Tasks
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public int TopTaskId { get; set; }

        public int ParentTaskId { get; set; }

        public string Details { get; set; }
    }
}