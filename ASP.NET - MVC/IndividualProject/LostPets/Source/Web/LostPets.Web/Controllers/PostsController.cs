namespace LostPets.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using ViewModels.Home;
    using ViewModels.Posts;

    using Infrastructure.Mapping;
    using Services.Data;

    public class PostsController : BaseController
    {
        private readonly IPostService posts;
        private readonly IImageService images;

        public PostsController(
            IPostService posts,
            IImageService images)
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
