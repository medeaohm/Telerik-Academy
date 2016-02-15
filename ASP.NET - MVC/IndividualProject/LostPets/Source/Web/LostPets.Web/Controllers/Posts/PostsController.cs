namespace LostPets.Web.Controllers
{
    using System.IO;
    using System.Linq;
    using System.Web.Mvc;
    using System.Web.Mvc.Html;

    using Infrastructure.Mapping;

    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.UI;

    using Data.Models;
    using Data.Models.Types;
    using Services.Data;
    using ViewModels.Home;
    using ViewModels.Posts;


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

        [Authorize]
        public ActionResult Add()
        {
            var addPostViewModel = new AddPostViewModel();

            return this.View(addPostViewModel);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(AddPostViewModel post)
        {
            if (post != null && this.ModelState.IsValid)
            {
                var dbPost = this.Mapper.Map<Post>(post);
                dbPost.Author = this.CurrentUser;

                if (post.UploadedImage != null)
                {
                    using (var memory = new MemoryStream())
                    {
                        post.UploadedImage.InputStream.CopyTo(memory);
                        var content = memory.GetBuffer();

                        dbPost.Gallery.Add(new Photo {
                            Content = content,
                            FileExtension = post.UploadedImage.FileName.Split(new[] { '.' }).Last()
                        });
                    }
                }

                this.posts.Update();

                return this.RedirectToAction("All", "Posts");
            }

            return this.View(post);
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
