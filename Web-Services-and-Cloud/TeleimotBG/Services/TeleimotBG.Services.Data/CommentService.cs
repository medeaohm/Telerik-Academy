namespace TeleimotBG.Services.Data
{
    using System;
    using System.Linq;

    using Models;
    using TeleimotBG.Data.Repositories;

    public class CommentService : ICommentService
    {
        private readonly IRealEstateService realEstate;
        private IRepository<Comment> comments;

        public CommentService(IRepository<Comment> comments, IRealEstateService realEstate)
        {
            this.comments = comments;
            this.realEstate = realEstate;
        }

        public IQueryable<Comment> GetCommentsForARealEstates(int estateId)
        {
            return this.comments
                 .All()
                 .Where(c => c.RealEstateId == estateId)
                 .OrderBy(c => c.CreatedOn)
                 .Skip(0)
                 .Take(10);
        }

        public IQueryable<Comment> GetCommentsForARealEstatesExtended(int estateId, int skip = 0, int take = 10)
        {
            return this.comments
                 .All()
                 .Where(c => c.RealEstateId == estateId)
                 .OrderBy(c => c.CreatedOn)
                 .Skip(skip*take)
                 .Take(take);
    }
    }
}
