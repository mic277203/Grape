using System.Threading.Tasks;
using Abp.Application.Services;
using Grape.Configuration.Dto;

namespace Grape.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}