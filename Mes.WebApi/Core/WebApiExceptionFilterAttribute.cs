using Mes.BLL.Comm;
using Mes.Common;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace Mes.WebApi.Core
{
    public class WebApiExceptionFilterAttribute : ExceptionFilterAttribute
    {
        //重写基类的异常处理方法
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            //异常日志记录
            string code = actionExecutedContext.Exception.Message;
            string filePath = HttpContext.Current.Request.FilePath;
            string lang =  HttpContext.Current.Request.Headers["lang"].ToString();
            var ex = (GlobalException)actionExecutedContext.Exception;
            string message = ExceptionComm.HandException(code, lang, ex.param);
            LogHelper.WriteLog(string.Format("Path:{0},message:{1}", filePath, message), actionExecutedContext.Exception);
            var oResponse = new HttpResponseMessage(HttpStatusCode.OK);
            JObject jr = new JObject();
            jr.Add("success", false);
            jr.Add("message", message);
            jr.Add("code", 200001);
            oResponse.Content = new StringContent(jr.ToString());
            //oResponse.ReasonPhrase = "This Func is Not Supported";


            actionExecutedContext.Response = oResponse;
            

            base.OnException(actionExecutedContext);
        }
    }
}