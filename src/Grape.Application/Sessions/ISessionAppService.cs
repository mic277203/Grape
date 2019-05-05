using System.Threading.Tasks;
using Abp.Application.Services;
using Grape.Sessions.Dto;

namespace Grape.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
