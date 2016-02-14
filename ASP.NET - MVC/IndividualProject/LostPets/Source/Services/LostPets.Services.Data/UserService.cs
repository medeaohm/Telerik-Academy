namespace LostPets.Services.Data
{
    using System.Linq;

    using LostPets.Data.Models;
    using LostPets.Data.Common.Repositories;

    public class UserService : IUserService
    {
        private IDeletableEntityRepository<User> users;

        public UserService(IDeletableEntityRepository<User> users)
        {
            this.users = users;
        }

        public IQueryable<User> All()
        {
            return this.users.All();
        }

        public User GetById(object id)
        {
            return this.users.GetById(id);
        }

        public void Update()
        {
            this.users.SaveChanges();
        }
    }
}