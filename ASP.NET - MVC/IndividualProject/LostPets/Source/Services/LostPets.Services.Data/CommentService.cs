﻿namespace LostPets.Services.Data
{
    using System.Linq;
    using LostPets.Data.Common.Repositories;
    using LostPets.Data.Models;
    using Web;

    public class CommentService : ICommentService
    {
        private readonly IIdentifierProvider identifierProvider;
        private IDeletableEntityRepository<Comment> comments;

        public CommentService(IDeletableEntityRepository<Comment> comments, IIdentifierProvider identifierProvider)
        {
            this.comments = comments;
            this.identifierProvider = identifierProvider;
        }

        public Comment GetById(string id)
        {
            var intId = this.identifierProvider.DecodeId(id);
            var comment = this.comments.GetById(intId);
            return comment;
        }

        public IQueryable<Comment> GetAll()
        {
            return this.comments.All().OrderBy(c => c.CreatedOn).ThenBy(c => c.Id);
        }

        public IQueryable<Comment> GetByPostId(int postId)
        {
            return this.comments
                .All()
                .Where(c => c.PostId == postId)
                .OrderBy(c => c.CreatedOn).ThenBy(c => c.Id);
        }

        public IQueryable<Comment> GetByUserId(string userId)
        {
            return this.comments
                .All()
                .Where(c => c.AuthorId == userId)
                .OrderBy(c => c.CreatedOn).ThenBy(c => c.Id);
        }

        public void Update()
        {
            this.comments.SaveChanges();
        }

        public void Add(Comment comment)
        {
            this.comments.Add(comment);
        }
    }
}
