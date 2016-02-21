﻿namespace LostPets.Web.Controllers
{
    using System.Web;
    using System.Web.Mvc;
    using Data.Models;
    using Services.Data;
    using ViewModels.Comments;
    using System.Globalization;

    public class CommentsController : BaseController
    {
        private IPostService posts;
        private ICommentService comments;

        public CommentsController(IPostService posts, ICommentService comments, IUserService users)
            : base(users)
        {
            this.posts = posts;
            this.comments = comments;
        }

        [Authorize]
        public ActionResult PostComment()
        {
            var postCommentViewModel = new PostCommentViewModel();

            return this.View(postCommentViewModel);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PostComment(PostCommentViewModel comment)
        {
            if (comment != null && this.ModelState.IsValid)
            {
                var databaseComment = new Comment
                {
                    Content = comment.Content,
                    PostId = comment.PostId,
                    Author = this.CurrentUser
                };

                var post = this.posts.GetById(comment.PostId);
                if (post == null)
                {
                    throw new HttpException(404, "Post not found");
                }

                post.Comments.Add(databaseComment);
                this.posts.Update();

                //ModelState["Content"].Value = new ValueProviderResult(string.Empty, "", CultureInfo.CurrentCulture);
                var viewModel = this.Mapper.Map<CommentViewModel>(databaseComment);
                //this.TempData["Notification"] = "Commented succesfully!";
                //ValueProviderResult abc = new ValueProviderResult("", "", System.Globalization.CultureInfo.CurrentCulture);
                //ModelState.SetModelValue("Content", abc);
                return this.PartialView("_CommentPartial", viewModel);
                //return this.RedirectToAction("Details", "Posts");
            }

            throw new HttpException(400, "Invalid comment!");
        }
    }
}
