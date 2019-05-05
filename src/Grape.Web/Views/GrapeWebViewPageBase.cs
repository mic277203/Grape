using Abp.Web.Mvc.Views;

namespace Grape.Web.Views
{
    public abstract class GrapeWebViewPageBase : GrapeWebViewPageBase<dynamic>
    {

    }

    public abstract class GrapeWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected GrapeWebViewPageBase()
        {
            LocalizationSourceName = GrapeConsts.LocalizationSourceName;
        }
    }
}