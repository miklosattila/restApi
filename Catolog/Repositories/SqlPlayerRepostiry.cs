using Catolog.Entities;

namespace Catolog.Repositories
{
    public class SqlPlayerRepository : IPlayerRepository
    {

        public SqlPlayerRepository()
        {
            
        }

        public void CreatePlayer(Player player)
        {
            throw new NotImplementedException();
        }

        public void DeletePlayer(Guid id)
        {
            throw new NotImplementedException();
        }

        public Player GetPlayer(Guid Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Player> GetPlayers()
        {
            throw new NotImplementedException();
        }

        public void UpdatePlayerScore(Player player)
        {
            throw new NotImplementedException();
        }
    }
} 