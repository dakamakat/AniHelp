using System.Threading;
using System.Threading.Tasks;
using Application.Account.Queries.ExportModels;
using Application.Common.Interfaces;
using MediatR;

namespace Application.Account.Queries.LogInAccount
{
    ///TODO : Add validation to comm/quer
    public class LogInAccountQuery : IRequest<AppUserVm>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }

    }
    public class LogInAccountQuerieHandler : IRequestHandler<LogInAccountQuery, AppUserVm>
    {
        private readonly IIdentityService _identityService;
        public LogInAccountQuerieHandler(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        public async Task<AppUserVm> Handle(LogInAccountQuery request, CancellationToken cancellationToken)
        {
            return await _identityService.LogInAsync(request.UserName, request.Password, request.RememberMe);
        }
    }
}
