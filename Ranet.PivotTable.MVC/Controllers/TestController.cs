using System.Web.Http;
using System.Web.Mvc;

namespace Ranet.PivotTable.MVC.Controllers
{
    public class TestController : ApiController
    {
        [System.Web.Http.HttpGet]
        [System.Web.Mvc.Route("api/test/test")]
        public string Test()
        {
            return "Success";
        }
    }
}