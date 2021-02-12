using System;

namespace InjazAnchor.Core.Entities.Sessions
{
    public class Session : BaseEntity
    {
        public DateTime StartedOn { get; set; }

        public DateTime EndedOn { get; set; }
    }
}