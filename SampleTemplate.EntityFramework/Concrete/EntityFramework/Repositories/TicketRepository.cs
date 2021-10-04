using Microsoft.EntityFrameworkCore;
using SampleTemplate.Entities.Domain;
using SampleTemplate.EntityFramework.Abstract;
using SampleTemplate.EntityFramework.Contexts;
using SampleTemplate.Shared.Domain.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace SampleTemplate.EntityFramework.Repositories
{
    public class TicketRepository : EfEntityRepositoryBase<Ticket>, ITicketRepository
    {
        public TicketRepository(DbContext dbContext) : base(dbContext)
        {
        }
        public List<Ticket> GetAllPagination()
        {
              var TicketList=db.Tickets.Where(ctx => ctx.IsActive).ToList();

            return TicketList;
        }

        public SampleTemplateContext db
        {
            get { return _dbContext as SampleTemplateContext; }
        }

    }
}
