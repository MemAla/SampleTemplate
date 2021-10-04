using SampleTemplate.Entities.Domain;
using SampleTemplate.Shared.Domain.Abstract;
using System.Collections.Generic;

namespace SampleTemplate.EntityFramework.Abstract
{
    public interface ITicketRepository : IEntityRepository<Ticket>
    {
        List<Ticket> GetAllPagination();
    }
}
