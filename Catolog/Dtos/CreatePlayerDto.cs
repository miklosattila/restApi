using System.ComponentModel.DataAnnotations;

namespace Catolog.Dtos
{
    public record CreatePlayerDto{
         
        [Required]
        public string? Name {get;set;}

        [Required]
        [Range(1,135)]
         public int Age {get;set;}

    }
}