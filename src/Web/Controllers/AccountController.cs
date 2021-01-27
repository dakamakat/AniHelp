using System.Threading.Tasks;
using Application.Account.Commands.RegisterAccount;
using Application.Common.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class AccountController : ApiControllerBase
    {
        [HttpPost]
        public async Task<(Result result, string userId)> Register([FromBody] RegisterAccountCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}
