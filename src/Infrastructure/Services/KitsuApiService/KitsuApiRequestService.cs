using System.Threading.Tasks;
using Application.Common.Interfaces;
using Application.Common.Models;
using Flurl;
using Flurl.Http;
using Infrastructure.Services.KitsuApiService.Constants;

namespace Infrastructure.Services.KitsuApiService.Contracts
{
    class KitsuApiRequestService : IRequestService<AnimeListKitsu>
    {
        /// TODO : replace Anime list by dto with less info
        public async Task<AnimeListKitsu> GetListOfAnime()
        {
            var url = UrlConstants.BaseUrl.AppendPathSegment("/anime");
            var result = await url.GetJsonAsync<AnimeListKitsu>();
            return result;
        }
    }
}
