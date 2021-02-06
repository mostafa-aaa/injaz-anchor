using System;

namespace InjazAnchor.Data.Entities.Sessions
{
    public class Session : BaseEntity
    {
        public DateTime StartedOn { get; set; }

        public DateTime EndedOn { get; set; }
    }
}