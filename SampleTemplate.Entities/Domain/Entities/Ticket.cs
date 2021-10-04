using SampleTemplate.Shared.Entities.Abstract;
using System;

namespace SampleTemplate.Entities.Domain
{
    public class Ticket : EntityBase, IEntity
    {
        public string Title { get; set; }
        public TicketPriority Priority { get; set; }
        public TicketStatus TicketStatus { get; set; }
        public string Description { get; set; }
        public Nullable<Boolean> Private { get; set; }
    }
}
