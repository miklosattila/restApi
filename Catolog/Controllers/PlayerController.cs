using Microsoft.AspNetCore.Mvc;
using Catolog.Repositories;
using Catolog.Entities;
using Catolog.Dtos;

namespace Catolog.Controllers;



    //GET /players
    [ApiController]
    [Route("players")]
    public class PlayerController : ControllerBase{
        private readonly IPlayerRepository repository;

        public PlayerController(IPlayerRepository repository)
        {
            this.repository= repository;
        }

        [HttpGet]
        public IEnumerable<PlayerDto> GetPlayers()
        {
            var players= repository.GetPlayers().Select(player => player.AsDto());
            return players;
        }

        [HttpGet("id")]
        public ActionResult<PlayerDto> GetPlayer(Guid Id)
        {
            var player = repository.GetPlayer(Id);

            if( player is null){
                return NotFound();
            } 
            return player.AsDto();

        }
        // Post /players
        [HttpPost]
        public ActionResult<PlayerDto> CreatePlayer(CreatePlayerDto playerDto){
            Player player =new(){
                Id=Guid.NewGuid(),
                Name=playerDto.Name,
                Age=playerDto.Age,
                CreatedDate=DateTimeOffset.UtcNow,
                ExitDate=DateTimeOffset.UtcNow,
                QuizScore=0,
                GameScore=0
            };

            repository.CreatePlayer(player);

            return CreatedAtAction(nameof(GetPlayer),new {id = player.Id},player.AsDto());
        }
        //PUT /players/id
        [HttpPut("id")]
        public ActionResult UpdatePlayerScore(Guid Id, UpdatePlayerScoreDto playerScoreDto){
            var existingPlayer = repository.GetPlayer(Id);

            if(existingPlayer is null){
                return NotFound();
            }

            Player updatedPlayerScore = existingPlayer with {
                QuizScore =  playerScoreDto.QuizScore,
                GameScore = playerScoreDto.GameScore
            };

            repository.UpdatePlayerScore(updatedPlayerScore);

            return NoContent();

        }

        // DELTE /players/id
        [HttpDelete("id")]
        public ActionResult DeletePlayer(Guid id){

            var existingPlayer = repository.GetPlayer(id);

            if(existingPlayer is null){
                return NotFound();
            }

            repository.DeletePlayer(id);

            return NoContent();
        }
    }   

