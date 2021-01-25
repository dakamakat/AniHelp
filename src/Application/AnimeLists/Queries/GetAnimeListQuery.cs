using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Application.Common.Models;
using MediatR;

namespace Application.AnimeLists.Queries
{
    public class GetAnimeListQuery : IRequest<AnimeList>
    {
    }
    public class GetAnimeListQueryHandler : IRequestHandler<GetAnimeListQuery, AnimeList>
    {

        private readonly IKistuRequestService _requestService;

        public GetAnimeListQueryHandler(IKistuRequestService requestService)
        {
            _requestService = requestService;
        }

        public async Task<AnimeList> Handle(GetAnimeListQuery request, CancellationToken cancellationToken)
        {
            return await _requestService.GetListOfAnimeAsync();
        }
    }
}
