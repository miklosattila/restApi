using Catolog.Dtos;
using Catolog.Entities;

namespace Catolog
{
    public static class Extensions{
        public static PlayerDto AsDto(this Player player)
      {
            return new PlayerDto{
                Id = player.Id,
                Name =player.Name,
                GameScore=player.GameScore,
                QuizScore=player.QuizScore
                
            };
    }
    }
}