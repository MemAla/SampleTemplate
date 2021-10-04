using SampleTemplate.Entities.Domain;
using SampleTemplate.Shared.Domain.Abstract;

namespace SampleTemplate.EntityFramework.Abstract
{
    public interface ICategoryRepository : IEntityRepository<Category>
    {
        
    }
}
