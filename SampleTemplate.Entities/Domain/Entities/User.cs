using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace SampleTemplate.Entities.Domain
{
    public class User: IdentityUser<int>
    {
        public User()
        {
            IsActive = true;
        }
        public string FullName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; } 
        public bool IsActive { get; set; }
    }
}
