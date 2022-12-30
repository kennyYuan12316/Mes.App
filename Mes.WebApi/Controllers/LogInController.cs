using Mes.BLL.Login;

using Mes.Common;
using Mes.Model.CommModel;
using Mes.Model.ViewModel;
using Mes.WebApi.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Security;
using Unity;

namespace Mes.WebApi.Controllers
{
   [RoutePrefix("api/LogIn")]
    public class LogInController : ApiController
    {

        [Dependency]
        public ILoginBLL loginBLL { get; set; }


        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="passsword">密码</param>
        /// <returns></returns>
        [HttpPost,Route("ValidateLogin")]
        public JsonResult<AjaxResult> ValidateLogin([FromBody] UserProfileVM userProfileVM)
        {
            JObject jr = new JObject();
            UserProfileVM userInfo = loginBLL.Login(userProfileVM);
            FormsAuthenticationTicket token = new FormsAuthenticationTicket(0, userProfileVM.userId, DateTime.Now,
                            DateTime.Now.AddHours(1), true, string.Format("{0}&{1}&{2}", userProfileVM.userId, userProfileVM.password, userInfo.deptId),
                            FormsAuthentication.FormsCookiePath);
            //返回登录结果、用户信息、用户验证票据信息
            var Token = FormsAuthentication.Encrypt(token);
            jr.Add("token", Token);
            jr.Add("userId", userInfo.userId);
            jr.Add("userName", userInfo.userName);
            return Json<AjaxResult>(AjaxResult.Success(jr));
        }


        [HttpGet,Route("getInfo")]
        public JsonResult<AjaxResult> GetInfo(string token)
        {
            LoginUserManage loginUserManage = new LoginUserManage();
            string userId = loginUserManage.DecryptToken(token);
            var userInfo  = loginBLL.GetUserInfo(userId);
            userInfo.password = null;
            return Json<AjaxResult>(AjaxResult.Success(userInfo));
        }
        
    }
}