using System.Threading.Tasks;
using Application.Common.Interfaces;
using Application.Common.Models;
using Flurl;
using Flurl.Http;
using Infrastructure.Services.KitsuApiService.Constants;
using Infrastructure.Services.KitsuApiService.Enums;

namespace Infrastructure.Services.KitsuApiService.Contracts
{
    class KitsuApiRequestService : IKistuRequestService
    {
        /// TODO : replace Anime list by dto with less info
        /// TODO: more complex requests (pagination sorting filtering)
        public async Task<AnimeList> GetListOfAnimeAsync()
        {
            var url = CreateUrl();
            var result = await url.GetJsonAsync<AnimeList>();
            return result;
        }
        public async Task<SingleAnime> GetAnimeByIdAsync(int id)
        {
            var url = CreateUrl(id);
            var result = await url.GetJsonAsync<SingleAnime>();
            return result;
        }

        private Url CreateUrl(int id = 0, MediaType type = MediaType.anime)
        {
            var url = UrlConstants.BaseUrl.AppendPathSegment($"/{type}");
            if (id != 0)
            {
                url.AppendPathSegment($"/{id}");
            };

            return url;
        }
    }
}
