using System.Threading.Tasks;
using Application.AnimeLists.Queries;
using Application.Common.Models;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class AnimeController : ApiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<AnimeList>> GetAnimeList()
        {
            return Ok(await Mediator.Send(new GetAnimeListQuery()));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AnimeList>> GetAnimeById(int id)
        {
            return Ok(await Mediator.Send(new GetAnimeByIdQuery { Id = id }));
        }

    }
}
