using SampleTemplate.EntityFramework.Abstract;
using SampleTemplate.EntityFramework.Contexts;
using SampleTemplate.EntityFramework.Repositories;
using System.Threading.Tasks;

namespace SampleTemplate.EntityFramework.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SampleTemplateContext _context;
        private readonly TicketRepository _ticketRepository;
        private readonly CategoryRepository _categoryRepository;
       
        public UnitOfWork(SampleTemplateContext context)
        {
            _context = context;
        }
        public ITicketRepository Ticket => _ticketRepository ?? new TicketRepository(_context);

        public ICategoryRepository Category=> _categoryRepository ?? new CategoryRepository(_context);

        public async Task<int> SaveAsync()
        {
           return await _context.SaveChangesAsync();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
    }
}
