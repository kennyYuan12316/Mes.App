using Mes.BLL.SystemManagement.Role;
using Mes.Common;
using Mes.Model.CommModel;
using Mes.Model.ViewModel;
using Mes.WebApi.Core;
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

namespace Mes.WebApi.Controllers.SystemManagement
{
    [RoutePrefix("api/Role")]
    public class RoleController :BaseApiController
    {
        [Dependency]
        public IRoleBLL roleBLL { get; set; }


        [HttpGet, Route("GetRoleTable")]
        public JsonResult<AjaxResult> GetRoleTable()
        {
          
            List<RoleVM> roleVMList = roleBLL.GetRoleTable();
            return Json<AjaxResult>(AjaxResult.Success(roleVMList));
        }


        [HttpGet, Route("GetRoleDetailTable/{roleId}")]
        public JsonResult<AjaxResult> GetRoleDetailTable(string roleId)
        {

            List<string> rolePremList = roleBLL.GetRoleDetailTable(roleId);
            return Json<AjaxResult>(AjaxResult.Success(rolePremList));
        }

        [HttpGet, Route("GetRoleDataByAcctId")]
        public JsonResult<AjaxResult> GetRoleDataByAcctId(string acctId)
        {
            List<RoleVM> roleVMList = roleBLL.GetRoleDataByAcctId(acctId);
            return Json<AjaxResult>(AjaxResult.Success(roleVMList));
        }



        [Route("AddOrUpdateRoleData")]
        [HttpPost]
        public JsonResult<JObject> AddOrUpdateRoleData([FromBody] JObject rolePermData)
        {
            JObject jr = new JObject();
            RolePermVM rolePermVM = rolePermData.ToString().DeserializeObject<RolePermVM>();
            rolePermVM.createUser = (string)HttpContext.Current.Items["userId"];
            bool operationFlag = roleBLL.AddOrUpdateRoleData(rolePermVM);
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

        [Route("DeleteRoleDataByRoleId")]
        [HttpPost]
        public JsonResult<AjaxResult> DeleteRoleDataByRoleId([FromBody] JObject delParas)
        {
            JObject jr = new JObject();
            string roleId = delParas["roleId"].ToString();
            bool OperaFlag = roleBLL.DeleteRoleDataByRoleId(roleId);
            if (OperaFlag)
            {
                return Json<AjaxResult>(AjaxResult.Success());
            }
            else
            {
                return Json<AjaxResult>(AjaxResult.Error());
            }
           
        }


        


    }
}
