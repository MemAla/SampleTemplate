using System;
using System.ComponentModel.DataAnnotations;

namespace SampleTemplate.Shared.Entities.Abstract
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedByName { get; set; }
        public int? ModifiedByName { get; set; }
        public int? DeletedBy { get; set; }
        public bool IsActive { get; set; } 
    }
}
