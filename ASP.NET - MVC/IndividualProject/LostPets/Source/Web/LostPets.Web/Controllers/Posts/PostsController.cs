namespace LostPets.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using Kendo.Mvc.UI;
    using Kendo.Mvc.Extensions;

    using ViewModels.Home;
    using ViewModels.Posts;

    using Infrastructure.Mapping;
    using Services.Data;
    using System.Web.Mvc.Html;
    using Data.Models.Types;

    public class PostsController : BaseController
    {
        private readonly IPostService posts;
        private readonly IImageService images;

        public PostsController(
            IPostService posts,
            IImageService images,
            IUserService users)
            : base(users)
        {
            this.posts = posts;
            this.images = images;
        }

        public ActionResult Details(string id)
        {
            var post = this.posts.GetById(id);
            var viewModel = this.Mapper.Map<PostViewModel>(post);
            return this.View(viewModel);
        }

        public ActionResult All()
        {
            var posts = this.posts.GetAll().To<PostViewModel>().ToList();
            var viewModel = new IndexViewModel {
                Posts = posts,
            };

            return this.View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult ReadPosts([DataSourceRequest]DataSourceRequest request)
        {
            var postsQuery = this.posts.GetAll();

            var posts = this.Mapper.Map<PostViewModel>(postsQuery);

            return this.Json(postsQuery.ToDataSourceResult(request));
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

        public ActionResult GetCategories()
        {
            return this.Json(EnumHelper.GetSelectList(typeof(PostType)), JsonRequestBehavior.AllowGet);
        }
    }
}
