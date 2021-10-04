using SampleTemplate.Shared.Entities.Abstract;
using System.Collections.Generic;

namespace SampleTemplate.Entities.Domain
{
    public class Category : EntityBase, IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
