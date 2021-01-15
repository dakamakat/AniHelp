using Flurl;
using Flurl.Http;
using System.Threading.Tasks;
using Infrastructure.Services.KitsuApiService.Constants;
using Infrastructure.Services.KitsuApiService.Contracts;
using Application.Common.Interfaces;
using Application.Common.Models;

namespace Infrastructure.Services.KitsuApiService.Contracts
{
    class KitsuApiRequestService : IRequestService<AnimeListDto>
    {
        /// TODO : replace Anime list by dto with less info
        public async Task<AnimeListDto> GetListOfAnime()
        {
            var url = UrlConstants.BaseUrl.AppendPathSegment("/anime");
            var result = await url.GetJsonAsync<AnimeListDto>();
            return result;
        }
    }
}
