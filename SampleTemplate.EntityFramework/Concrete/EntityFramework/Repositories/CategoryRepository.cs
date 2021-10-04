using Microsoft.EntityFrameworkCore;
using SampleTemplate.Entities.Domain;
using SampleTemplate.EntityFramework.Abstract;
using SampleTemplate.Shared.Domain.Concrete;

namespace SampleTemplate.EntityFramework.Repositories
{
    public class CategoryRepository : EfEntityRepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
