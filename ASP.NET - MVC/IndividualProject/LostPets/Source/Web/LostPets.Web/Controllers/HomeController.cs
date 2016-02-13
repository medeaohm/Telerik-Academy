namespace LostPets.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using Infrastructure.Mapping;

    using Services.Data;

    using ViewModels.Home;
    using ViewModels.Posts;

    public class HomeController : BaseController
    {
        private readonly IPostService posts;

        public HomeController(IPostService posts)
        {
            this.posts = posts;
        }

        public ActionResult Index()
        {
            var posts =
                this.Cache.Get(
                    "posts",
                    () => this.posts.GetMostRecent(8).To<PostViewModel>().ToList(),
                    10 * 60);

            var viewModel = new IndexViewModel
            {
                Posts = posts
            };

            return this.View(viewModel);
        }
    }
}
