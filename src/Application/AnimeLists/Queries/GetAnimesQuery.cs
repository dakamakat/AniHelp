using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Flurl;
using Flurl.Http;
using Application.Common.Models;
using Application.Common.Constants;
using static Application.Common.Models.AnimeProductions;

namespace Application.AnimeLists.Queries
{
    public class GetAnimesQuery : IRequest<AnimeList>
    {
    }
    public class GetAnimesQueryHandler : IRequestHandler<GetAnimesQuery , AnimeList>
    {

        //TODO define a class (T above) that matches the shape of the expected JSON response.
        public async Task<AnimeList> Handle(GetAnimesQuery request, CancellationToken cancellationToken)
        {
            var url = Constants.BaseUrl.AppendPathSegment("/anime");
            var result = await url.GetJsonAsync<AnimeList>();
            return result;
        }
    }
}
