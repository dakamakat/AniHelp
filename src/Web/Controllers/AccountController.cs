using System.Threading.Tasks;
using Application.Account.Commands.RegisterAccount;
using Application.Account.Queries.ExportModels;
using Application.Account.Queries.LogInAccount;
using Application.Common.Models;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class AccountController : ApiControllerBase
    {
        [HttpPost]
        [Route("register")]
        public async Task<(Result result, string userId)> Register([FromBody] RegisterAccountCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPost]
        [Route("logIn")]
        public async Task<AppUserVm> LogIn([FromBody] LogInAccountQuery command)
        {
            return await Mediator.Send(command);
        }
    }
}
