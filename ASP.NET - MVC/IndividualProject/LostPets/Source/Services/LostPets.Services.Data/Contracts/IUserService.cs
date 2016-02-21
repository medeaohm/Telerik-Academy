namespace LostPets.Services.Data
{
    using System.Linq;
    using LostPets.Data.Models;

    public interface IUserService
    {
        IQueryable<User> All();

        User GetById(object id);

        void Update();
    }
}
