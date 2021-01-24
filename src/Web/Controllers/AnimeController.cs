using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Application.AnimeLists.Queries;
using Application.Common.Models;
using Infrastructure.Services.KitsuApiService.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class AnimeController : ApiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<AnimeList>> Get()
        {
            return Ok(await Mediator.Send(new GetAnimeListQuery()));
        }
    }
}
