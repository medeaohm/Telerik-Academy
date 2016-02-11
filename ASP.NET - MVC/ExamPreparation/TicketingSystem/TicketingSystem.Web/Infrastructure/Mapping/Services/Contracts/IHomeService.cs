namespace TicketingSystem.Web.Infrastructure.Mapping.Services.Contracts
{
    using System.Collections.Generic;
    using TicketingSystem.Web.ViewModels.Home;

    public interface IHomeService
    {
        IList<TicketViewModel> GetIndexViewModel(int numberOfTickets);
    }
}