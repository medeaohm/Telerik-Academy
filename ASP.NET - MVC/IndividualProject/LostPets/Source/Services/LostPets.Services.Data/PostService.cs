namespace LostPets.Services.Data
{
    using System.Linq;
    using Web;

    using LostPets.Data.Common;
    using LostPets.Data.Models;
    using LostPets.Data.Models.Types;

    public class PostService : IPostService
    {
        private readonly IDbRepository<Post> posts;
        private readonly IIdentifierProvider identifierProvider;

        public PostService(IDbRepository<Post> posts, IIdentifierProvider identifierProvider)
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
