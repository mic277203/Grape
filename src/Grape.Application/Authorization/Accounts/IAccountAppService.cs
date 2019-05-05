using System.Threading.Tasks;
using Abp.Application.Services;
using Grape.Authorization.Accounts.Dto;

namespace Grape.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
