using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using AspnetBoilerplate.Demo.Controllers;

namespace AspnetBoilerplate.Demo.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : DemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
