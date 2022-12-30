
using Mes.BLL.Main;
using Mes.Common;
using Mes.Model.CommModel;
using Mes.Model.ViewModel;
using Mes.WebApi.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using Unity;

namespace Mes.WebApi.Controllers
{
    [RoutePrefix("api/Main")]
    public class MainController : BaseApiController
    {

        [Dependency]
        public IMainBLL mainBLL { get; set; }

        [Route("GetTreeMenu")]
        [HttpPost]
        public JsonResult<AjaxResult> GetTreeMenu(string userId)
        {
            JObject jr = new JObject();
            JArray tree =  mainBLL.GetOrganizationTree(userId);
            return Json<AjaxResult>(AjaxResult.Success(tree));
        }

        [Route("GetComponentBtnPower")]
        [HttpGet]
        public JsonResult<JObject> GetComponentBtnPower(string componetName)
        {
            JObject jr = new JObject();
            string userId= (string)HttpContext.Current.Items["userId"];
            List<PermsPageKeyCodeVM> permsPageKeyCodeVMlist= mainBLL.GetComponentBtnPower(componetName,userId);
            jr.Add("data",permsPageKeyCodeVMlist.SerializeObject() );
            jr.Add("code", 20000);
            return Json<JObject>(jr);
        }
    }
}
