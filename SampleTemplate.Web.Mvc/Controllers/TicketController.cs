using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SampleTemplate.Application.Domain;

namespace SampleTemplate.Web.Mvc.Controllers
{
    public class TicketController : Controller
    {
        private readonly ILogger<TicketController> _logger;
        private readonly ITicketApplicationService _ticketAppService;
        public TicketController(
            ILogger<TicketController> logger,
            ITicketApplicationService ticketAppService)
        {
            _logger = logger;
            _ticketAppService = ticketAppService;
        }
        public IActionResult Index()
        {
            var Model = _ticketAppService.GetTicketList(new TicketSummaryInput()).Result;
            
            return View(Model);
        }

        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(TicketCreateInput model)
        {
            var IsSucces=_ticketAppService.CreateTicket(model);

            return RedirectToAction("Index");
        }
    }
}
