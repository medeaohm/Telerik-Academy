using BullsAndCows.Data.Models;
using System.Linq;

namespace BullsAndCows.Services.Data
{
    public interface IGameService
    {
        IQueryable<Game> GetPublicGames(int page = 0, string userId = null);
    }
}
