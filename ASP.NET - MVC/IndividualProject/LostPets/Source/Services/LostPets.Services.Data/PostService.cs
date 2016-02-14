namespace LostPets.Services.Data
{
    using System.Linq;
    using Web;

    using LostPets.Data.Common;
    using LostPets.Data.Models;
    using LostPets.Data.Models.Types;
    using LostPets.Data.Common.Repositories;

    public class PostService : IPostService
    {
        private readonly IIdentifierProvider identifierProvider;
        private IDeletableEntityRepository<Post> posts;

        public PostService(IDeletableEntityRepository<Post> posts, IIdentifierProvider identifierProvider)
        {
            this.posts = posts;
            this.identifierProvider = identifierProvider;
        }

        public Post GetById(string id)
        {
            var intId = this.identifierProvider.DecodeId(id);
            var post = this.posts.GetById(intId);
            return post;
        }

        public IQueryable<Post> GetAll()
        {
            return this.posts.All().OrderByDescending(p => p.CreatedOn);
        }

        public IQueryable<Post> GetMostRecent(int count)
        {
            return this.posts.All().OrderByDescending(p => p.CreatedOn).Take(count);
        }

        public IQueryable<Post> GetByType(PostType postType)
        {
            return this.posts.All().Where(p => p.PostType == postType);
        }

        public IQueryable<Post> GetByAnimalType(AnimalType animalType)
        {
            return this.posts.All().Where(p => p.AnimalType == animalType);
        }
    }
}
