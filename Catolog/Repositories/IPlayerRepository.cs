using Catolog.Entities;

namespace Catolog.Repositories;

public interface IPlayerRepository
{
    Player GetPlayer(Guid Id);
    IEnumerable<Player> GetPlayers();

    void CreatePlayer(Player player);

    void UpdatePlayerScore(Player player);

    void DeletePlayer(Guid id);
}