namespace LostPets.Services.Data
{
    using System.Linq;

    using LostPets.Data.Models;

    public interface IJokesService
    {
        IQueryable<Joke> GetRandomJokes(int count);

        Joke GetById(string id);
    }
}
