using SampleTemplate.Application.Abstract;
using SampleTemplate.Entities.Domain;
using SampleTemplate.EntityFramework.Abstract;
using SampleTemplate.Shared.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SampleTemplate.Application.Domain
{
    public class TicketApplicationService : BaseManagement, ITicketApplicationService
    {
        public TicketApplicationService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public ResponseData<List<Ticket>> GetTicketList(TicketSummaryInput input)
        {
            var ApiResult = new ResponseData<List<Ticket>>();
            
            var TicketList = _unitOfWork.Ticket.FindByCondition(x => x.IsActive).ToList();

            ApiResult.Result = TicketList;

            return ApiResult.Success(ApiResult.Result);
        }

        public ResponseData<string> CreateTicket(TicketCreateInput input)
        {
            var ApiResult = new ResponseData<string>();

            _unitOfWork.Ticket.Create(new Ticket
            {
                Title=input.Title,
                Description=input.Description,
                TicketStatus=TicketStatus.Open,
                Priority= (TicketPriority)Enum.Parse(typeof(TicketPriority), input.Priority),
                Private =input.Private,
                IsActive=true,
                CreatedByName=123,
                CreatedDate=DateTime.Now
            });

            _unitOfWork.SaveChanges();

            return ApiResult.Success(input.Title);
        }

        public ResponseData<string> UpdateTicket(TicketCreateInput input)
        {
            var ApiResult = new ResponseData<string>();
            var Ticket = _unitOfWork.Ticket.FindByIntId(input.Id.Value);
            
            Ticket.Title = input.Title;
            Ticket.Description = input.Description;
            Ticket.Priority = (TicketPriority)Enum.Parse(typeof(TicketPriority), input.Priority);
            Ticket.TicketStatus = (TicketStatus)Enum.Parse(typeof(TicketStatus), input.TicketStatus);
            Ticket.Private = input.Private;
            Ticket.ModifiedByName = 123;
            Ticket.ModifiedDate = DateTime.Now;

            _unitOfWork.Ticket.Update(Ticket);
            _unitOfWork.SaveChanges();

            return ApiResult.Success(Ticket.Id.ToString());

        }
    }
}
