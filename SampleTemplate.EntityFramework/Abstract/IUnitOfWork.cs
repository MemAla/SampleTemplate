using System;
using System.Threading.Tasks;

namespace SampleTemplate.EntityFramework.Abstract
{
    public interface IUnitOfWork: IAsyncDisposable
    {
        ITicketRepository Ticket { get; }
        ICategoryRepository Category{ get; }
        Task<int> SaveAsync();
        void SaveChanges();
    }
}
