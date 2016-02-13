﻿namespace LostPets.Web.Controllers
{
    using System.Web;
    using System.Web.Mvc;

    using LostPets.Services.Data;
    using ViewModels.Posts;

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

        public ActionResult Image(int id)
        {
            var image = this.images.GetById(id);

            if (image == null)
            {
                throw new HttpException(404, "Image not found!");
            }

            return this.File(image.Content, "image/" + image.FileExtension);
        }
    }
}