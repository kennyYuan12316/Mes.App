
using Mes.Common;
using Mes.WebApi.Core;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Mes.WebApi.Core
{
    [SupportFilter]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class BaseApiController : ApiController
    {

        protected virtual HttpRequestBase httpRequestBase
        {
            get
            {
                var context = (HttpContextBase)Request.Properties[ConfigPara.MS_HttpContext];
                return context.Request;
            }
        }
    }
}