using Mes.BLL.SystemManagement.Organization;
using Mes.Common;
using Mes.Model.CommModel;
using Mes.Model.Entites;
using Mes.Model.ViewModel;
using Mes.WebApi.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using Unity;

namespace Mes.WebApi.Controllers.SystemManagement
{

    [RoutePrefix("api/Organization")]
    public class OrganizationController : BaseApiController
    {

        [Dependency]
        public IOrganizationBLL organizationBLL { get; set; }

        [HttpPost]
        public JsonResult<JObject> GetOrganizationMenu()
        {
            JObject jr = new JObject();
            JArray tree = organizationBLL.GetOrganizationMenu();
            jr.Add("data", tree);
            jr.Add("code", 20000);
            return Json<JObject>(jr);
        }

        /// <summary>
        /// 组织架构详情分页
        /// </summary>
        /// <param name="deptIdArr"></param>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        [Route("PostOrganizationTable/{page}/{size}")]
        [HttpPost]
        public JsonResult<JObject> PostOrganizationTable([FromBody] JObject deptIdArr,int page,int size)
        {
            JObject jr = new JObject();
            string arr = deptIdArr["deptIdArr"].ToString();
            List<string> list = JsonConvert.DeserializeObject<List<string>>(arr);
            int total = 0;
            List<OrganizationVM> organizationTable = organizationBLL.GetOrganizationTableById(list.ToArray(), page,size, ref  total);
            jr.Add("data", organizationTable.SerializeObject());
            jr.Add("total",total);
            jr.Add("code", 20000);
            return Json<JObject>(jr);
        }

        
        [HttpGet, Route("GetAllOrganization")]
        public JsonResult<AjaxResult> GetAllOrganization()
        {
            return Json(AjaxResult.Success(organizationBLL.GetAllOrganization()));
        }

        [Route("AddOrUpdate")]
        [HttpPost]
        public JsonResult<JObject> AddOrUpdate([FromBody] JObject org)
        {
            JObject jr = new JObject();
            OrganizationVM organizationVM = JsonConvert.DeserializeObject<OrganizationVM>(org.ToString());
            organizationVM.createUser = (string)HttpContext.Current.Items["userId"];
            bool addFlag = organizationBLL.AddOrUpdate(organizationVM);
            if (addFlag)
            {
                jr.Add("message", "保存成功");
                jr.Add("code", 20000);
            }
            else
            {
                jr.Add("message", "保存失败");
                jr.Add("code", 20001);
            }

            return Json<JObject>(jr);
        }


        [Route("GetDeptById")]
        [HttpGet]
        public JsonResult<JObject> GetDeptById(string deptId)
        {
            JObject jr = new JObject();
            OrganizationVM organizationVM = organizationBLL.GetDeptById(deptId);
            if (organizationVM == null)
            {
                jr.Add("message", "获取失败");
                jr.Add("code", 20001);
            }
            else
            {
                jr.Add("data", organizationVM.SerializeObject());
                jr.Add("message", "获取成功");
                jr.Add("code", 20000);
            }

            return Json<JObject>(jr);
        }

        /// <summary>
        /// 上传文件
        /// </summary>
        /// <returns></returns>
        [HttpPost,Route("UploadOrganizationExcel")]
        public JsonResult<AjaxResult> UploadOrganizationExcel()
        {
            // 获取以表单形式提交的文件
            //HttpContext.Current.Request["name"] 获取表单的数据
            var files = HttpContext.Current.Request.Files;
            string fileName = files[0].FileName;
            var stream =  files[0].InputStream; 
            var list = ExcelHelper.ExcelToList<TB_HR_Dept>(fileName, stream, true, null);
            return Json(AjaxResult.Success(list));
        }

    }
}