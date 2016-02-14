namespace LostPets.Web.Controllers.Account
{
    using System.IO;
    using System.Linq;
    using System.Web.Mvc;

    using Data.Models;
    using Services.Data;
    using ViewModels.Settings;
    using System.Web;

    public class SettingsController : BaseController
    {
        private IImageService images;

        public SettingsController(IUserService users, IImageService images)
            : base(users)
        {
            this.images = images;
        }

        // GET: Settings
        public ActionResult UpdateProfile(string id)
        {
            var user = this.Mapper.Map<UpdateProfileViewModel>(this.users.GetById(id));
            return this.View(user);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateProfile(HttpPostedFileBase file, string id)
        {
            var user = this.users.GetById(this.CurrentUser.Id);

            if (file != null)
            {
                using (var memory = new MemoryStream())
                {
                    var content = memory.GetBuffer();

                    user.ProfilePicture = new Photo {
                        Content = content,
                        FileExtension = file.FileName.Split(new[] { '.' }).Last()
                    };
                    this.images.Update();
                    this.users.Update();
                }
            }

            return this.RedirectToAction("UpdateProfile");
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