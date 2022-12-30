using Mes.BLL.SystemManagement.AccountManage;
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
    [RoutePrefix("api/Account")]
    public class AccountController : BaseApiController
    {

        [Dependency]
        public IAccountManageBLL acctManageBLL { get; set; }

        [HttpGet, Route("GetAccoutByDeptIdTable")]
        public JsonResult<AjaxResult> GetAccoutByDeptIdTable(string deptId)
        {
            List<AccountVM> accountVMList = acctManageBLL.GetAccoutByDeptIdTable(deptId);
            return Json<AjaxResult>(AjaxResult.Success(accountVMList));
        }

        [Route("AddOrUpdateAccountData")]
        [HttpPost]
        public JsonResult<AjaxResult> AddOrUpdateAccountData([FromBody] JObject acctRolePermVM)
        {
            AccountRolePermVM accountRolePerm = acctRolePermVM.ToString().DeserializeObject<AccountRolePermVM>();
            accountRolePerm.createUser = (string)HttpContext.Current.Items["userId"];
            bool reuslt = acctManageBLL.AddOrUpdateAccountData(accountRolePerm);
            if (reuslt)
            {
                return Json<AjaxResult>(AjaxResult.Success());
            }
            else
            {
                return Json<AjaxResult>(AjaxResult.Error());
            }
        }

        [HttpGet, Route("GetPermDataByAcctId")]
        public JsonResult<AjaxResult> GetPermDataByAcctId(string acctId)
        {
            List<string> permList = acctManageBLL.GetPermDataByAcctId(acctId);
            return Json<AjaxResult>(AjaxResult.Success(permList));
        }

        [HttpGet, Route("GetAccountRolePermByAccountId")]
        public JsonResult<AjaxResult> GetAccountRolePermByAccountId(string acctId)
        {
            AccountRolePermVM accountRolePermVM = acctManageBLL.GetAccountRolePermByAccountId(acctId);
            return Json<AjaxResult>(AjaxResult.Success(accountRolePermVM));
        }
        [Route("DeleteAccountRolePermByAccountId")]
        [HttpPost]
        public JsonResult<AjaxResult> DeleteAccountRolePermByAccountId([FromBody] JObject delParas)
        {
            string acctId = delParas["acctId"].ToString();
            bool reuslt = acctManageBLL.DeleteAccountRolePermByAccountId(acctId);
            if (reuslt)
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
