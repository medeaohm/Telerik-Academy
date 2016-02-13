namespace LostPets.Services.Data
{
    using LostPets.Data.Common;
    using LostPets.Data.Models;
    using Web;

    public class ImageService : IImageService
    {
        private readonly IDbRepository<Photo> images;
        private readonly IIdentifierProvider identifierProvider;

        public ImageService(IDbRepository<Photo> images, IIdentifierProvider identifierProvider)
        {
            this.images = images;
            this.identifierProvider = identifierProvider;
        }

        public Photo GetById(int id)
        {
            return this.images.GetById(id);
        }
    }
}
