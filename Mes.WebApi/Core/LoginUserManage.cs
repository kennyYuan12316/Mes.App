using Mes.BLL.Account;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Security;
using Unity;

namespace Mes.WebApi.Core
{
    public class LoginUserManage
    {

        public IAccountBLL accountBLL = new AccountBLL();

        /// <summary>
        /// 添加用户登陆信息
        /// </summary>
        /// <param name="sessID">SessionID</param>
        /// <param name="name">登陆名称</param>
        public  void Add(String sessID, String name)
        {
            NameValueCollection loginUsers = HttpContext.Current.Application["__LoginUsers"] as NameValueCollection;
            if (loginUsers == null)
            {
                loginUsers = new NameValueCollection();
            }
            loginUsers.Set(name, sessID);
            HttpContext.Current.Application["__LoginUsers"] = loginUsers;

        }
        /// <summary>
        /// 移除登陆信息
        /// </summary>
        /// <param name="name">登陆名称</param>
        public  void Remove(String name)
        {
            NameValueCollection loginUsers = HttpContext.Current.Application["__LoginUsers"] as NameValueCollection;
            if (loginUsers != null)
            {
                loginUsers.Remove(name);
            }
            HttpContext.Current.Application["__LoginUsers"] = loginUsers;
        }

        /// <summary>
        ///  验证用户状态是否改变
        /// </summary>
        /// <param name="sessId">sessionid</param>
        /// <param name="name">session</param>
        /// <returns></returns>
        public  bool IsChange(String sessId, String name)
        {
            Boolean bResult = false;
            NameValueCollection loginUsers = HttpContext.Current.Application["__loginUsers"] as NameValueCollection;
            if (loginUsers != null)
            {
                String oldSessId = loginUsers.GetValues(name)[0];
                if (!String.IsNullOrEmpty(oldSessId) && !sessId.Equals(oldSessId))
                {
                    bResult = true;
                }
            }
            return bResult;
        }
        /// <summary>
        /// 验证是否有单机限制
        /// </summary>
        /// <param name="account">用户信息</param>
        /// <returns>验证结果：true有限制，false没有</returns>
        //public static bool ValidateRelogin(AccountModel account)
        //{
        //    bool bResult = false;
        //    if (account != null)
        //    {
        //        SysConfigModel siteConfig = new SysConfigBLL().loadConfig(Utils.GetXmlMapPath("Configpath"));
        //        if (siteConfig.issinglelogin == 1)
        //        {
        //            if (IsChange(HttpContext.Current.Session.SessionID, account.Id))
        //            {
        //                //同一帐号已经在其他机子登录
        //                bResult = true;
        //                RedirectUrl();
        //            }
        //        }
        //    }
        //    return bResult;
        //}
        /// <summary>
        /// 验证是否已经登录
        /// </summary>
        /// <param name="account">account</param>
        /// <returns>验证结果：true已经登录，false没有登录</returns>
        //public static bool ValidateIsLogined(AccountModel account)
        //{

        //    if (account == null)
        //    {
        //        RedirectUrl();
        //    }

        //    return true;
        //}
        /// <summary>
        /// 失效（错误）窗口提示
        /// </summary>
        /// <param name="message">提示消息</param>
        /// <param name="url">URL地址，可选参数，为空则只弹出对话框，而不刷新页面</param>
        public  void RedirectUrl()
        {

            string href = HttpContext.Current.Request.Url.ToString();
            HttpContext.Current.Response.Redirect("/Account/index?url=" + href);
            HttpContext.Current.Response.End();

        }
        public static void RedirectUrlFor401()
        {

            HttpContext.Current.Response.Write("401");
            HttpContext.Current.Response.End();

        }
        //校验用户名密码（对Session匹配，或数据库数据匹配）
        public  bool ValidateTicket(string encryptToken)
        {
            //解密Ticket
            var userId = DecryptToken(encryptToken.Trim());
            //判断用户是否存在
            return accountBLL.ExistUser(userId);

        }

        /// <summary>
        /// 揭秘Token获得当前用户
        /// </summary>
        /// <param name="encryptToken">Token</param>
        /// <returns>userName</returns>
        public  string DecryptToken(string encryptToken)
        {
            var strTicket = FormsAuthentication.Decrypt(encryptToken.Trim()).UserData;
            //从Ticket里面获取用户名和密码
            var index = strTicket.IndexOf("&");
            string userName = strTicket.Substring(0, index);
            //string password = strTicket.Substring(index + 1);
            return userName;
        }
    }
}