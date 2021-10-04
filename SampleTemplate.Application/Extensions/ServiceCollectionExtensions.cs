using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SampleTemplate.Application.Domain;
using SampleTemplate.Entities.Domain;
using SampleTemplate.EntityFramework.Abstract;
using SampleTemplate.EntityFramework.Concrete;
using SampleTemplate.EntityFramework.Contexts;
using SampleTemplate.EntityFramework.Repositories;

namespace ProgrammersBlog.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection, string connectionString)
        {
            serviceCollection.AddDbContext<SampleTemplateContext>(options => options.UseSqlServer(connectionString));

            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();

            serviceCollection.AddScoped<ITicketApplicationService, TicketApplicationService>();
            serviceCollection.AddScoped<IUserApplicationService, UserApplicationService>();

            return serviceCollection;
        }
    }
}
