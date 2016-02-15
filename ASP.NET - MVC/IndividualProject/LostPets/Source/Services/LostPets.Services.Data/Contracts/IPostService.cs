namespace LostPets.Services.Data
{
    using System.Linq;

    using LostPets.Data.Models;
    using LostPets.Data.Models.Types;

    public interface IPostService
    {
        Post GetById(string id);

        IQueryable<Post> GetAll();

        IQueryable<Post> GetMostRecent(int count);

        IQueryable<Post> GetByType(PostType postType);

        IQueryable<Post> GetByAnimalType(AnimalType animalType);

        void Update();
    }
}
