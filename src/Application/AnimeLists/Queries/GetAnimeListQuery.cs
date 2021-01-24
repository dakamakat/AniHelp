using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Application.Common.Models;
using MediatR;

namespace Application.AnimeLists.Queries
{
    public class GetAnimeListQuery : IRequest<AnimeListKitsu>
    {
    }
    public class GetAnimeListQueryHandler : IRequestHandler<GetAnimeListQuery, AnimeListKitsu>
    {

        private readonly IRequestService<AnimeListKitsu> _requestService;

        public GetAnimeListQueryHandler(IRequestService<AnimeListKitsu> requestService, IAniHelpDbContext dbContext)
        {
            _requestService = requestService;
        }

        public async Task<AnimeListKitsu> Handle(GetAnimeListQuery request, CancellationToken cancellationToken)
        {
            return await _requestService.GetListOfAnime();
        }
    }
}
