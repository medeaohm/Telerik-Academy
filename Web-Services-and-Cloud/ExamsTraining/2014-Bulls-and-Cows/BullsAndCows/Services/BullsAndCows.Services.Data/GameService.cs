namespace BullsAndCows.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using BullsAndCows.Data.Models;
    using BullAndCows.Data.Repositories;

    public class GameService : IGameService
    {
        private IRepository<Game> games;

        public GameService(IRepository<Game> games)
        {
            this.games = games;
        }

        public IQueryable<Game> GetPublicGames(int page = 1, string userId = null)
        {
            return this.games
                .All()
                .Where(g => g.GameState == GameState.WaitingForOpponent
                    || g.GameState != GameState.WaitingForOpponent 
                    && (g.RedUserId == userId) || g.BlueUserId == userId)
                .OrderBy(g => g.GameState)
                .ThenBy(g => g.Name)
                .ThenBy(g => g.DateCreated)
                .ThenBy(g => g.RedUser.Email)
                .Skip((page - 1) * 10)
                .Take(10);
        }
    }
}
