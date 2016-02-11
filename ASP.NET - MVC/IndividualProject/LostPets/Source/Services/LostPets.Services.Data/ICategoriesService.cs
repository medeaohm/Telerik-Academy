namespace LostPets.Services.Data
{
    using System.Linq;

    using LostPets.Data.Models;

    public interface ICategoriesService
    {
        IQueryable<JokeCategory> GetAll();

        JokeCategory EnsureCategory(string name);
    }
}
