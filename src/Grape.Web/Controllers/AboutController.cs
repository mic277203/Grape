using System.Web.Mvc;

namespace Grape.Web.Controllers
{
    public class AboutController : GrapeControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}