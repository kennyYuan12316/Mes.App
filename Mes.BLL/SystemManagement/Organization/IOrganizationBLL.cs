using Mes.Model.Entites;
using Mes.Model.ViewModel;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.BLL.SystemManagement.Organization
{
    public interface IOrganizationBLL
    {
        /// <summary>
        /// 获取组织架构树
        /// </summary>
        /// <returns></returns>
        JArray GetOrganizationMenu();
        List<OrganizationVM> GetOrganizationTableById(string[] deptIdArr, int page, int size, ref int total);

        /// <summary>
        /// 获取所有组织架构
        /// </summary>
        /// <returns></returns>
        List<OrganizationVM> GetAllOrganization();

        /// <summary>
        /// 新增或修改组织架构
        /// </summary>
        /// <param name="organizationVM"></param>
        /// <returns></returns>
        bool AddOrUpdate(OrganizationVM organizationVM);
        bool AddOrganizationalStructureBatch(List<TB_HR_Dept> list);

        /// <summary>
        /// 根据id获取组织架构
        /// </summary>
        /// <param name="deptId"></param>
        /// <returns></returns>
        OrganizationVM GetDeptById(string deptId);
        

    }
}
