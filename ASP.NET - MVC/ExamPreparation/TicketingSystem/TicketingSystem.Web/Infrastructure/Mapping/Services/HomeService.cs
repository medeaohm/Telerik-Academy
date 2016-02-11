namespace TicketingSystem.Web.Infrastructure.Mapping.Services
{
    using AutoMapper.QueryableExtensions;
    using System.Collections.Generic;
    using System.Linq;
    using TicketingSystem.Data;
    using TicketingSystem.Web.Infrastructure.Mapping.Services.Base;
    using TicketingSystem.Web.Infrastructure.Mapping.Services.Contracts;
    using TicketingSystem.Web.ViewModels.Home;

    public class HomeService : BaseServices, IHomeService
    {
        public HomeService(ITicketSystemData data)
            :base(data)
        {
        }

        public IList<TicketViewModel> GetIndexViewModel(int numberOfTickets)
        {
            var indexViewModel = this.Data
                .Tickets
                .All()
                .OrderByDescending(t => t.Comments.Count())
                .Take(numberOfTickets)
                .Project()
                .To<TicketViewModel>()
                .ToList();

            return indexViewModel;
        }
    }
}