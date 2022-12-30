using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.Model.CommModel
{
    /// <summary>
    /// controller返回结果集
    /// </summary>
    public class AjaxResult
    {


        public AjaxResult()
        {
                
        }

        public AjaxResult(bool success, object data, int code,string message)
        {
            this.success = success;
            this.data = data;
            this.code = code;
            this.message = message;
        }

        /// <summary>
        /// 是否成功
        /// </summary>
        public bool success { set; get; }
        /// <summary>
        /// 返回的结果数据
        /// </summary>
        public object data { set; get; }
 
        /// <summary>
        /// 提示信息
        /// </summary>
        public string message { set; get; }


        public int code { set; get; }


        public static AjaxResult Success()
        {
            return new AjaxResult(true, null, 20000,"ok");
        }

        public static AjaxResult Success(string message)
        {
            return new AjaxResult(true, null, 20000,message);
        }

        public static AjaxResult Success(int code ,string message)
        {
            return new AjaxResult(true, null, code, message);
        }
        
        public static AjaxResult Success(int code, string message,object data)
        {
            return new AjaxResult(true, data, code, message);
        }

        public static AjaxResult Success( object data)
        {
            return new AjaxResult(true, data, 20000, "ok");
        }


        public static AjaxResult Error(int code, string message, object data)
        {
            return new AjaxResult(false, data, code, message);
        }

        public static AjaxResult Error()
        {
            return new AjaxResult(false, null, 20001, "error");
        }

        public static AjaxResult Error(int code, string message)
        {
            return new AjaxResult(false, null, code, message);
        }






    }
}
