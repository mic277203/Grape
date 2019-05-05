using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Grape.MultiTenancy.Dto;

namespace Grape.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
