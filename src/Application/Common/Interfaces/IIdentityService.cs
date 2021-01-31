using System.Threading.Tasks;
using Application.Account.Queries.ExportModels;
using Application.Common.Models;

namespace Application.Common.Interfaces
{
    public interface IIdentityService
    {
        Task<string> GetUserNameAsync(string userId);

        Task<(Result result, string userId)> CreateUserAsync(string userName, string password);

        Task<AppUserVm> LogInAsync(string userName, string password, bool rememberMe);

        Task<Result> DeleteUserAsync(string userId);
    }
}
