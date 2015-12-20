namespace TeleimotBG.Services.Data
{
    using System.Linq;
    using TeleimotBG.Models;

    public interface ICommentService
    {
        IQueryable<Comment> GetCommentsForARealEstates(int estateId);

        IQueryable<Comment> GetCommentsForARealEstatesExtended(int estateId, int skip = 0, int take = 10);
    }
}
