using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Application.Common.Models;
using MediatR;

namespace Application.AnimeLists.Queries
{
    public class GetAnimeByIdQuery : IRequest<SingleAnime>
    {
        public int Id { get; set; }
    }
    public class GetAnimeByIdQueryHandler : IRequestHandler<GetAnimeByIdQuery, SingleAnime>
    {

        private readonly IKistuRequestService _requestService;

        public GetAnimeByIdQueryHandler(IKistuRequestService requestService)
        {
            _requestService = requestService;
        }

        public async Task<SingleAnime> Handle(GetAnimeByIdQuery request, CancellationToken cancellationToken)
        {
            return await _requestService.GetAnimeByIdAsync(request.Id);
        }
    }
}
