using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketingSystem.Data;
using TicketingSystem.Models;
using TicketingSystem.Web.ViewModels.Comments;

namespace TicketingSystem.Web.Controllers
{
    public class CommentsController : BaseController
    {
        public CommentsController(ITicketSystemData data)
            : base(data)
        {

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PostComment(PostCommentViewModel comment)
        {
            if (comment != null && ModelState.IsValid)
            {
                var dbComment = Mapper.Map<Comment>(comment);
                dbComment.Author = this.UserProfile;

                var ticket = this.Data.Tickets.GetById(comment.TicketId);
                if (ticket == null)
                {
                    throw new HttpException(404, "Ticket not found");
                }

                ticket.Comments.Add(dbComment);
                this.Data.SaveChanges();

                var viewModel = Mapper.Map<CommentViewModel>(dbComment);
                return PartialView("_CommentPartial", viewModel);
            }

            throw new HttpException(400, "Invalid comment!");
        }
    }
}