namespace Catolog.Dtos
{
    public record PlayerDto
    {
        public Guid Id {get;init;}

        public string? Name {get;set;}


        public int QuizScore {get; set;}

        public int GameScore {get;set;}


    }
}
