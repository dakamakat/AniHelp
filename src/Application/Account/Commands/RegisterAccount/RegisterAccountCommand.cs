using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Application.Common.Models;
using MediatR;

namespace Application.Account.Commands.RegisterAccount
{
   public class RegisterAccountCommand : IRequest<(Result result, string userId)>
    {
        public string UserName { get; set; }
        public string  Password { get; set; }
       
    }
    public class RegisterAccountCommandHandler : IRequestHandler<RegisterAccountCommand, (Result result, string userId)>
    {
        private readonly IIdentityService _identityService;
        public RegisterAccountCommandHandler(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        public async Task<(Result result, string userId)> Handle(RegisterAccountCommand request, CancellationToken cancellationToken)
        {
            return await _identityService.CreateUserAsync(request.UserName, request.Password);
        }
    }
}
