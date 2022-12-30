using Mes.Common;
using Mes.Model.Entites;
using Mes.Model.ViewModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mes.BLL.SystemManagement.Organization
{
    public class OrganizationBLL : IOrganizationBLL
    {
        /// <summary>
        /// 组织架构保存接口
        /// </summary>
        /// <param name="organizationData">组织架构参数</param>
        /// <returns></returns>
        public bool AddOrUpdate(OrganizationVM organizationVM)
        {
            bool insertFlag = false;
            using (MesDB db = new MesDB())
            {
                var tbDept = db.TB_Sys_Department.Where(f => f.FC_DeptId == organizationVM.deptId).FirstOrDefault();
                if (tbDept == null)
                {
                    TB_Sys_Department dept = new TB_Sys_Department();
                    dept.FC_DeptId = organizationVM.deptId;
                    dept.FC_DeptName = organizationVM.deptName;
                    dept.FC_ParentID = organizationVM.parentId;
                    dept.FC_Remark = organizationVM.remark;
                    dept.FB_Status = organizationVM.status;
                    dept.FC_CUser = organizationVM.createUser;
                    dept.FD_CDate = DateTime.Now;
                    dept.FD_UDate = DateTime.Now;
                    dept.FC_UUser = organizationVM.createUser;
                    db.TB_Sys_Department.Add(dept);
                }
                else
                {
                    tbDept.FC_DeptId = organizationVM.deptId;
                    tbDept.FC_DeptName = organizationVM.deptName;
                    tbDept.FC_ParentID = organizationVM.parentId;
                    tbDept.FC_Remark = organizationVM.remark;
                    tbDept.FB_Status = organizationVM.status;
                    tbDept.FD_UDate = DateTime.Now;
                    tbDept.FC_UUser = organizationVM.createUser;
                }
                if (db.SaveChanges() > 0)
                {
                    return insertFlag = true;
                }
                else
                {
                    return insertFlag;
                }
            }
        }

        public List<TB_HR_Dept> GetAllOrganization()
        {
            List<OrganizationVM> orgList = new List<OrganizationVM>();
            using (MesDB db = new MesDB())
            {
                var tbDeptList= db.TB_Sys_Department.ToList();
                foreach (var item in tbDeptList)
                {
                    OrganizationVM orgVM = new OrganizationVM();
                    orgVM.deptId = item.FC_DeptId;
                    orgVM.deptName = item.FC_DeptName;
                    orgVM.parentId = item.FC_ParentID;
                    orgVM.status = item.FB_Status;
                    orgVM.remark = item.FC_Remark;
                    orgList.Add(orgVM);
                }

                return orgList;
            }
        }

        public OrganizationVM GetDeptById(string deptId)
        {
            OrganizationVM organizationVM = null;
            using (MesDB db = new MesDB())
            {
                var tbDept = db.TB_Sys_Department.Where(f => f.FC_DeptId == deptId).FirstOrDefault();
                if (tbDept != null)
                {
                    organizationVM = new OrganizationVM();
                    organizationVM.deptId = tbDept.FC_DeptId;
                    organizationVM.deptName = tbDept.FC_DeptName;
                    organizationVM.parentId = tbDept.FC_ParentID;
                    organizationVM.status = tbDept.FB_Status;
                    organizationVM.remark = tbDept.FC_Remark;
                }
                return organizationVM;
            }
        }

        /// <summary>
        /// 获取组织架构菜单
        /// </summary>
        /// <returns></returns>
        public JArray GetOrganizationMenu()
        {
            JArray navTree = new JArray();
            using (MesDB db = new MesDB())
            {
                var organizationQuery = db.TB_Sys_Department.ToList();
                var top = from q in organizationQuery
                          where q.FC_ParentID == null
                          select q;
                if (top.Count() > 0)
                {
                    foreach (var item in top)
                    {
                        JArray submenlist = new JArray();
                        GetChilds(item.FC_DeptId, organizationQuery, submenlist);
                        if (submenlist.Count > 0)
                            navTree.Add(
                                      new JObject(
                                        new JProperty("label", item.FC_DeptName),
                                        new JProperty("children", submenlist),
                                        new JProperty("id", item.FC_DeptId)
                                        )
                                      );
                    }
                }
            }
            return navTree;
        }

        public List<OrganizationVM> GetOrganizationTableById(string[] deptIdArr, int page, int size, ref int total)
        {
            total = 0;
            List<OrganizationVM> orgTotal = new List<OrganizationVM>();
            List<OrganizationVM> orgList = new List<OrganizationVM>();
            using (MesDB db = new MesDB())
            {
                var tbDeptlist = db.TB_Sys_Department.Where(f => deptIdArr.Contains(f.FC_DeptId)).OrderBy(f => f.FC_DeptId).ToList();
                foreach (var item in tbDeptlist)
                {
                    OrganizationVM organizationVM = new OrganizationVM();
                    organizationVM.deptId = item.FC_DeptId;
                    organizationVM.deptName = item.FC_DeptName;
                    organizationVM.parentId = item.FC_ParentID;
                    organizationVM.remark = item.FC_Remark;
                    organizationVM.status = item.FB_Status;
                    orgTotal.Add(organizationVM);
                }

                orgList = LinqHelper.DataPaging(orgTotal.AsQueryable(), page, size).ToList();
                int count = orgTotal.ToList().Count;
                total = count % size == 0 ? count / size : count / size + 1;
            }
            return orgList;
        }
        /// <summary>
        /// 递归函数
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="datas"></param>
        /// <param name="array"></param>
        private void GetChilds(string parent, List<TB_Sys_Department> datas, JArray array)
        {
            var dd = (from d in datas
                      where d.FC_ParentID == parent
                      select d).ToList();
            if (dd.Count == 0)
                return;
            else
            {
                for (int i = 0; i < dd.Count; i++)
                {
                    JArray submenlist = new JArray();
                    GetChilds(dd[i].FC_DeptId, datas, submenlist);
                    array.Add(
                                     new JObject(
                                       new JProperty("label", dd[i].FC_DeptName),
                                       new JProperty("children", submenlist),
                                       new JProperty("id", dd[i].FC_DeptId)
                                       )
                                     );
                }
            }
        }


    }
}
