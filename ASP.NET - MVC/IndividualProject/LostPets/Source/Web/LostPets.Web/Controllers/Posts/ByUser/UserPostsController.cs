namespace LostPets.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Mvc;

    using Data.Models.Types;
    using Infrastructure.Mapping;
    using Services.Data;
    using ViewModels.Posts;
    using System.Net;

    public class UserPostsController : BaseController
    {
        private const int ItemsPerPage = 4;

        private IPostService posts;
        private IImageService images;
        private IPetService pets;
        private ILocationService locations;

        public UserPostsController(
            IPostService posts,
            IImageService images,
            IUserService users,
            IPetService pets,
            ILocationService locations)
            : base(users)
        {
            this.posts = posts;
            this.images = images;
            this.pets = pets;
            this.locations = locations;
        }

        [Authorize]
        [HttpGet]
        public ActionResult AllByUser(PostType? postType = null, PetType? petType = null, City? city = null, int id = 1)
        {
            PageableListPostViewModel viewModel;
            if (this.HttpContext.Cache["Post page_" + id] != null)
            {
                viewModel = (PageableListPostViewModel)this.HttpContext.Cache["Post page_" + id];
            }
            else
            {
                var page = id;
                var allItemsCount = this.posts.GetByUserId(this.CurrentUser.Id).Count();
                var totalPages = (int)Math.Ceiling(allItemsCount / (decimal)ItemsPerPage);
                var itemsToSkip = (page - 1) * ItemsPerPage;
                var queryPosts = this.posts.GetByUserId(this.CurrentUser.Id);

                if (postType != null)
                {
                    queryPosts = queryPosts.Where(p => p.PostType == postType);
                }

                if (petType != null)
                {
                    queryPosts = queryPosts.Where(p => p.Pet.PetType == petType);
                }

                if (city != null)
                {
                    queryPosts = queryPosts.Where(p => p.Location.City == city);
                }

                queryPosts = queryPosts.OrderBy(x => x.CreatedOn)
                    .ThenBy(x => x.Id)
                    .Skip(itemsToSkip)
                    .Take(ItemsPerPage);

                var posts = queryPosts.To<PostViewModel>().ToList();

                viewModel = new PageableListPostViewModel()
                {
                    CurrentPage = page,
                    TotalPages = totalPages,
                    Posts = posts
                };

                this.HttpContext.Cache["Feedback page_" + id] = viewModel;
            }

            return this.View(viewModel);
        }

        [Authorize]
        public ActionResult DeletePost(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var post = this.posts.GetById(id);
            if (post == null)
            {
                return this.HttpNotFound();
            }

            var viewModel = this.Mapper.Map<PostViewModel>(post);
            return this.View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            this.posts.Delete(id);
            this.posts.Update();
            return this.RedirectToAction("AllByUser");
        }

        public ActionResult Image(int id)
        {
            var image = this.images.GetById(id);

            if (image == null)
            {
                return this.File(this.images.GetById(0).Content, "image/" + image.FileExtension);
            }

            return this.File(image.Content, "image/" + image.FileExtension);
        }
    }
}
