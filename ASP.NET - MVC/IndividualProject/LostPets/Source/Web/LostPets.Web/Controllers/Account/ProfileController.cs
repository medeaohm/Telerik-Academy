namespace LostPets.Web.Controllers.Account
{
    using System.IO;
    using System.Linq;
    using System.Web.Mvc;

    using Data.Models;
    using Services.Data;
    using ViewModels.Profile;

    public class ProfileController : BaseController
    {
        private IImageService images;

        public ProfileController(IUserService users, IImageService images)
            : base(users)
        {
            this.images = images;
        }

        public ActionResult ViewMyProfile()
        {
            var user = this.Mapper.Map<ProfileViewModel>(this.users.GetById(this.CurrentUser.Id));
            return this.View(user);
        }

        public ActionResult ViewUserProfile(string id)
        {
            var user = this.Mapper.Map<ProfileViewModel>(this.users.GetById(id));
            return this.View(user);
        }

        public ActionResult EditProfile(string id)
        {
            var user = this.Mapper.Map<ProfileViewModel>(this.users.GetById(this.CurrentUser.Id));
            return this.View(user);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditProfile(ProfileViewModel profile, string id)
        {
            var user = this.users.GetById(this.CurrentUser.Id);

            user.FirstName = profile.FirstName;

            if (profile.UploadedImage != null)
            {
                using (var memory = new MemoryStream())
                {
                    profile.UploadedImage.InputStream.CopyTo(memory);
                    var content = memory.GetBuffer();

                    user.ProfilePicture = new Photo
                    {
                        Content = content,
                        FileExtension = profile.UploadedImage.FileName.Split(new[] { '.' }).Last()
                    };
                    this.images.Update();
                }
            }

            this.users.Update();
            return this.RedirectToAction("ViewMyProfile");
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
