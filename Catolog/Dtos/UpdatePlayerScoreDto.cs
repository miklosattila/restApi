using System.ComponentModel.DataAnnotations;

namespace Catolog.Dtos
{
    public record UpdatePlayerScoreDto{
         
        public int QuizScore {get; set;}

        public int GameScore {get;set;}

    }
}