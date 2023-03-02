namespace Catolog.Entities
{
    public record Player
    {
        public Guid Id {get;init;}

        public string? Name {get;set;}

        public int Age {get;set;}

    

        public DateTimeOffset CreatedDate {get; init; }

        public DateTimeOffset ExitDate {get;set;}

        public int QuizScore {get; set;}

        public int GameScore {get;set;}


    }
}