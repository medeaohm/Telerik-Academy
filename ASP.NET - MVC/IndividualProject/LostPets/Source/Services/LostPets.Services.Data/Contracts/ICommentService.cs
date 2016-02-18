namespace LostPets.Services.Data
{
    using System.Linq;
    using LostPets.Data.Models;

    public interface ICommentService
    {
        Comment GetById(string id);

        IQueryable<Comment> GetAll();

        IQueryable<Comment> GetByPostId(int postId);

        IQueryable<Comment> GetByUserId(string userId);

        void Update();

        void Add(Comment comment);
    }
}
