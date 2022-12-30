using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using Mes.Common;
using Newtonsoft.Json.Linq;

namespace Mes.WebApi.Core
{
    /// <summary>
    /// 响应后置拦截器
    /// </summary>
    public class CustomActionAttribute : ActionFilterAttribute
    {


        //public override Task OnActionExecutingAsync(HttpActionContext actionContext, CancellationToken cancellationToken)
        //{
        //    if (isNoResponseFilter(actionContext))//是否该类标记为NoLog
        //    {
        //        return base.OnActionExecutingAsync(actionContext, cancellationToken);

        //    }

        //    return base.OnActionExecutingAsync(actionContext, cancellationToken);
        //}

        // 响应后处理
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            var httpResponse = actionExecutedContext.Response;
            string json =  GetResponseValues(actionExecutedContext);
            JObject jr = json.DeserializeObject<JObject>();
            // 去数据库查询message去查询message
            jr["message"] = "OK";
            httpResponse.Content = new StringContent(jr.SerializeObject());
            base.OnActionExecuted(actionExecutedContext);
        }


        /// <summary>
        /// 读取request 的提交内容
        /// </summary>
        /// <param name="actionExecutedContext"></param>
        /// <returns></returns>
        public string GetRequestValues(HttpActionExecutedContext actionExecutedContext)
        {

            Stream stream = actionExecutedContext.Request.Content.ReadAsStreamAsync().Result;
            Encoding encoding = Encoding.UTF8;
            /*
                这个StreamReader不能关闭，也不能dispose， 关了就傻逼了
                因为你关掉后，后面的管道  或拦截器就没办法读取了
            */
            var reader = new StreamReader(stream, encoding);
            string result = reader.ReadToEnd();
            /*
            这里也要注意：   stream.Position = 0;
            当你读取完之后必须把stream的位置设为开始
            因为request和response读取完以后Position到最后一个位置，交给下一个方法处理的时候就会读不到内容了。
            */
            stream.Position = 0;
            return result;
        }

        /// <summary>
        /// 读取action返回的result
        /// </summary>
        /// <param name="actionExecutedContext"></param>
        /// <returns></returns>
        public string GetResponseValues(HttpActionExecutedContext actionExecutedContext)
        {
            Stream stream = actionExecutedContext.Response.Content.ReadAsStreamAsync().Result;
            Encoding encoding = Encoding.UTF8;
            /*
            这个StreamReader不能关闭，也不能dispose， 关了就傻逼了
            因为你关掉后，后面的管道  或拦截器就没办法读取了
            */
            var reader = new StreamReader(stream, encoding);
            string result = reader.ReadToEnd();
            /*
            这里也要注意：   stream.Position = 0; 
            当你读取完之后必须把stream的位置设为开始
            因为request和response读取完以后Position到最后一个位置，交给下一个方法处理的时候就会读不到内容了。
            */
            stream.Position = 0;
            return result;
        }


        /// <summary>
        /// 判断类和方法头上的特性是否要进行Action拦截
        /// </summary>
        /// <param name="actionContext"></param>
        /// <returns></returns> 
        private static bool isNoResponseFilter(HttpActionContext actionContext)
        {
            return actionContext.ActionDescriptor.GetCustomAttributes<NoResponseFilterAttribute>().Any() || actionContext.ActionDescriptor.ControllerDescriptor.GetCustomAttributes<NoResponseFilterAttribute>().Any();
        }

    }
}