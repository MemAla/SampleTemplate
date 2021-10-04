using System;

namespace SampleTemplate.Application.Domain
{
    public class TicketFullOutput
    {
        public string Title { get; set; }
        public string Priority { get; set; }
        public string TicketStatus { get; set; }
        public string Description { get; set; }
        public Boolean? Private { get; set; }
    }
}
