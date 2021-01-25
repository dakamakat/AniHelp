using System.Threading.Tasks;
using Application.Common.Models;

namespace Application.Common.Interfaces
{
    public interface IKistuRequestService
    {
        Task<AnimeList> GetListOfAnimeAsync();
        Task<SingleAnime> GetAnimeByIdAsync(int id);
    }
}
