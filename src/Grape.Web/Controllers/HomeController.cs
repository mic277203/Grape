using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Grape.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : GrapeControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}