using Mes.BLL.Account;
using Mes.BLL.SystemManagement.Organization;
using Mes.BLL.Login;
using Mes.BLL.Main;
using System.Web.Http;
using Unity;
using Unity.AspNet.WebApi;
using Mes.BLL.SystemManagement.Module;
using Mes.BLL.SystemManagement.DataDic;
using Mes.BLL.SystemManagement.AccountManage;
using Mes.BLL.SystemManagement.Role;

namespace Mes.WebApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container
                .RegisterType<ILoginBLL, LoginBLL>()
                .RegisterType<IMainBLL, MainBLL>()
                .RegisterType<IOrganizationBLL, OrganizationBLL>()
                .RegisterType<IAccountBLL, AccountBLL>()
                .RegisterType<IModuleBLL, ModuleBLL>().
                RegisterType<IDataDicBLL, DataDicBLL>().
                RegisterType<IAccountManageBLL, AccountManageBLL>()
                .RegisterType<IRoleBLL, RoleBLL>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}