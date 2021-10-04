using SampleTemplate.Entities.Domain;
using SampleTemplate.Shared.Extensions;
using System.Collections.Generic;

namespace SampleTemplate.Application.Domain
{
    public interface ITicketApplicationService
    {
        ResponseData<List<Ticket>> GetTicketList(TicketSummaryInput input);

        ResponseData<string> CreateTicket(TicketCreateInput input);

        ResponseData<string> UpdateTicket(TicketCreateInput input);   
    }
}
