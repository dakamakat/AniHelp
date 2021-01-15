using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Application.Common.Models;
using MediatR;

namespace Application.AnimeLists.Queries
{
    public class GetAnimesQuery : IRequest<AnimeListDto>
    {
    }
    public class GetAnimesQueryHandler : IRequestHandler<GetAnimesQuery, AnimeListDto>
    {

        private readonly IRequestService<AnimeListDto> _requestService;

        public GetAnimesQueryHandler(IRequestService<AnimeListDto> requestService, IAniHelpDbContext dbContext)
        {
            _requestService = requestService;
        }

        public async Task<AnimeListDto> Handle(GetAnimesQuery request, CancellationToken cancellationToken)
        {
            return await _requestService.GetListOfAnime();
        }
    }
}
