namespace TicketingSystem.Web.Controllers
{
    using AutoMapper.QueryableExtensions;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    using TicketingSystem.Data;
    using Infrastructure.Populators;
    using TicketingSystem.Web.ViewModels.Tickets;
    using TicketingSystem.Web.ViewModels.Comments;
    using Models;
    using System.IO;
    using Kendo.Mvc.UI;
    using Kendo.Mvc.Extensions;

    public class TicketsController : BaseController
    {
        private IDropDownListPopulator populator;

        public TicketsController(ITicketSystemData data, IDropDownListPopulator populator)
            : base(data)
        {
            this.populator = populator;
        }

        public ActionResult All(int? category)
        {
            return View(category);
        }

        [Authorize]
        [HttpPost]
        public ActionResult ReadTickets([DataSourceRequest]DataSourceRequest request, int? category)
        {
            var queryTickets = this.Data.Tickets.All();

            if (category != null)
            {
                queryTickets = queryTickets.Where(t => t.CategoryId == category.Value);
            }
 
            var tickets = queryTickets
                .Project()
                .To<ListTicketViewModel>();

            return Json(tickets.ToDataSourceResult(request));
        }

        [Authorize]
        public ActionResult Add()
        {
            var addTicketViewModel = new AddTicketViewModel
            {
                Categories = this.Data.Categories
                .All()
                .Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Name
                })
            };

            return View(addTicketViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Add(AddTicketViewModel ticket)
        {
            if (ticket != null && ModelState.IsValid)
            {
                var dbTicket = AutoMapper.Mapper.Map<Ticket>(ticket);
                dbTicket.Author = this.UserProfile;
                if (ticket.UploadedImage != null)
                {
                    using (var memory = new MemoryStream())
                    {
                        ticket.UploadedImage.InputStream.CopyTo(memory);
                        var content = memory.GetBuffer();

                        dbTicket.Image = new Image
                        {
                            Content = content,
                            FileExtension = ticket.UploadedImage.FileName.Split('.').Last()
                        };
                    }
                }
                this.Data.Tickets.Add(dbTicket);
                this.Data.SaveChanges();

                return RedirectToAction("All", "Tickets");
            }

            ticket.Categories = this.populator.GetCategories();
            return View(ticket);
        }

        public ActionResult Details(int id)
        {
            var ticket = this.Data
                .Tickets
                .All()
                .Where(t => t.Id == id)
                .Project()
                .To<TicketDetailsViewModel>()
                .FirstOrDefault();

            if (ticket == null)
            {
                throw new HttpException(404, "Ticket not found");
            }

            ticket.Comments = this.Data
                .Comments
                .All()
                .Where(c => c.TicketId == ticket.Id)
                .OrderByDescending(c => c.Id)
                .Project()
                .To<CommentViewModel>()
                .ToList();

            return View(ticket);
        }

        public ActionResult Image(int id)
        {
            var image = this.Data.Images.GetById(id);

            if (image == null)
            {
                throw new HttpException(404, "Image not found!");
            }

            return File(image.Content, "image/" + image.FileExtension);
        }

        public ActionResult GetCategories()
        {
            return Json(this.populator.GetCategories(), JsonRequestBehavior.AllowGet);
        }
    }
}