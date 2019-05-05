using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Grape.Roles.Dto;
using Grape.Users.Dto;

namespace Grape.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}