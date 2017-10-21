using Project.Http.Helpers;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Project.Http.Controllers
{
    [Route("http/{action}")]
    public class HomeController : BaseController
    {

        Domain.PersonalDataService DataService = new Domain.PersonalDataService();
         


        [HttpGet , AllowAnonymous]
        public HttpResponseMessage GetPersonelDataList()
        {
            return Request.CreateResponse(HttpStatusCode.OK,DataService.PersonalGetDataList());
        }




    }
}
