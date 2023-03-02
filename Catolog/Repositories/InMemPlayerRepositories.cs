namespace Catolog.Repositories;

using System.Collections.Generic;
using Catolog.Entities;
using System.Linq;

class InMemPlayerRepositories : IPlayerRepository
{
    private readonly List<Player> Players = new()
    {
        new Player {

            Id=Guid.NewGuid(),
            Name="Player1",
            Age=0,
            CreatedDate=DateTimeOffset.UtcNow,
            ExitDate=DateTimeOffset.UtcNow,

        },
        new Player {

            Id=Guid.NewGuid(),
            Name="Player2",
            Age=2,
            CreatedDate=DateTimeOffset.UtcNow,
            ExitDate=DateTimeOffset.UtcNow,

        },
        new Player {

            Id=Guid.NewGuid(),
            Name="Player3",
            Age=3,
            CreatedDate=DateTimeOffset.UtcNow,
            ExitDate=DateTimeOffset.UtcNow,

        },
    };

    public IEnumerable<Player> GetPlayers()
    {
        return Players;
    }

    public Player GetPlayer(Guid Id)
    {
        return Players.Where(Player => Player.Id == Id).SingleOrDefault();
    }

    public void CreatePlayer(Player player)
    {
        Players.Add(player);
    }

    public void UpdatePlayerScore(Player player)
    {
        var index = Players.FindIndex(existingPlayer => existingPlayer.Id == player.Id);
        Players[index]=player;
    }

    public void DeletePlayer(Guid id)
    {
        var index = Players.FindIndex(existingPlayer => existingPlayer.Id == id);

        Players.RemoveAt(index);
    }
}