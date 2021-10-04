using System.ComponentModel.DataAnnotations;

namespace SampleTemplate.Application.Domain
{
    public class TicketCreateInput
    {
        public int? Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        public string TicketStatus { get; set; }
        public string Priority { get; set; }

        [Required]
        public string Description { get; set; }
        public bool Private { get; set; }
    }
}
