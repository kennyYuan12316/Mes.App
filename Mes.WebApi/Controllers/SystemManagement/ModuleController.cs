using Mes.BLL.SystemManagement.Module;
using Mes.Common;
using Mes.Model.CommModel;
using Mes.Model.Entites;
using Mes.Model.ViewModel;
using Mes.WebApi.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using Unity;

namespace Mes.WebApi.Controllers.SystemManagement
{
    [RoutePrefix("api/Module")]
    public class ModuleController : BaseApiController
    {

        [Dependency]
        public IModuleBLL moduleBLL { get; set; }


        [HttpGet, Route("GetModuleTree")]
        public JsonResult<JObject> GetModuleTree()
        {
            JObject jr = new JObject();
            JArray tree = moduleBLL.GetModuleTree();
            jr.Add("data", tree);
            jr.Add("code", 20000);
            return Json<JObject>(jr);
        }


        /// <summary>
        /// 获取模板数据
        /// </summary>
        /// <param name="moduleArr"></param>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        [Route("PostModuletable")]
        [HttpPost]
        public JsonResult<JObject> PostModuleTable([FromBody] JObject moduleData)
        {
            JObject jr = new JObject();
            string parentId = moduleData["parentId"].ToString();
            int page = int.Parse(moduleData["page"].ToString());
            int size = int.Parse(moduleData["size"].ToString());
            int total = 0;
            List<ModuleVM> moduleTable = moduleBLL.GetModuleTable(parentId, page, size, ref total);
            jr.Add("data", moduleTable.SerializeObject());
            jr.Add("total", total);
            jr.Add("code", 20000);
            return Json<JObject>(jr);
        }


        [Route("GetModuleById")]
        [HttpGet]
        public JsonResult<JObject> GetModuleById(string moduleId)
        {
            JObject jr = new JObject();
            ModuleVM moduleVM = moduleBLL.GetModuleById(moduleId);
            if (moduleVM == null)
            {
                jr.Add("message", "获取失败");
                jr.Add("code", 20001);
            }
            else
            {
                jr.Add("data", moduleVM.SerializeObject());
                jr.Add("message", "获取成功");
                jr.Add("code", 20000);
            }

            return Json<JObject>(jr);
        }


        [Route("GetDictDetailForCatCode")]
        [HttpGet]
        public JsonResult<JObject> GetDictDetailForCatCode(string catCode)
        {
            JObject jr = new JObject();
            List<KeyValuePair> buttonPermissionsList = moduleBLL.GetDictDetailForDicCode(catCode);
            if (buttonPermissionsList.Count==0)
            {
                jr.Add("message", "获取失败");
                jr.Add("code", 20001);
            }
            else
            {
                jr.Add("data", buttonPermissionsList.SerializeObject());
                jr.Add("message", "获取成功");
                jr.Add("code", 20000);
            }
            return Json<JObject>(jr);
        }

        


        [Route("AddOrUpdateModuleData")]
        [HttpPost]
        public JsonResult<JObject> AddOrUpdateModuleData([FromBody] JObject moduleData)
        {
            JObject jr = new JObject();
            ModuleVM moduleVM = JsonConvert.DeserializeObject<ModuleVM>(moduleData.ToString());
            moduleVM.userId = (string)HttpContext.Current.Items["userId"];
            bool operationFlag = moduleBLL.AddOrUpdateModuleData(moduleVM);
            if (operationFlag)
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


        [Route("DeleteModuleDataByModuleId")]
        [HttpPost]
        public JsonResult<JObject> DeleteModuleDataByModuleId([FromBody] JObject delParas)
        {
            JObject jr = new JObject();
            string modCode = delParas["modCode"].ToString();
            bool OperaFlag = moduleBLL.DeleteModuleDataByModuleId(modCode);
            if (OperaFlag == false)
            {
                jr.Add("message", "获取失败");
                jr.Add("code", 20001);
            }
            else
            {
                jr.Add("message", "获取成功");
                jr.Add("code", 20000);
            }
            return Json<JObject>(jr);
        }

        [HttpGet, Route("GetModuleDetailTree")]
        public JsonResult<AjaxResult> GetModuleDetailTree(bool disableStatus)
        {
            JArray tree = moduleBLL.GetModuleDetailTree(disableStatus);
            return Json<AjaxResult>(AjaxResult.Success(tree));
        }

    }
}