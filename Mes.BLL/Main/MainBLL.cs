
using Mes.BLL.Comm;
using Mes.Model.Entites;
using Mes.Model.StoredProcedure;
using Mes.Model.ViewModel;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Mes.BLL.Main
{
    public class MainBLL : IMainBLL
    {
        public List<PermsPageKeyCodeVM> GetComponentBtnPower(string componetName, string userId)
        {
            List<PermsPageKeyCodeVM> permsPageKeyCodeVMList = new List<PermsPageKeyCodeVM>();
            using (MesDB db = new MesDB())
            {
                var list = db.TB_Sys_AccountPerm.Where(f => f.FC_AcctId == userId && f.FC_ModCode == componetName).ToList();

                foreach (var item in list)
                {
                    PermsPageKeyCodeVM permsPageKeyCodeVM = new PermsPageKeyCodeVM();
                    permsPageKeyCodeVM.componetName = item.FC_ModCode;
                    permsPageKeyCodeVM.keyCode = item.FC_BtnCode;
                    permsPageKeyCodeVM.userId = item.FC_AcctId;
                    permsPageKeyCodeVMList.Add(permsPageKeyCodeVM);
                }
                var tbroleList = (from g in db.TB_Sys_AccountRole.Where(f => f.FC_AcctId == userId)
                                  from f in db.TB_Sys_RoleDetail.Where(f => f.FC_RoleID == g.FC_RoleId && f.FC_ModCode == componetName)
                                  select f
                          ).ToList();
                foreach (var item in tbroleList)
                {
                    var IsHasPermsPageKeyCode = permsPageKeyCodeVMList.Where(f => f.componetName == item.FC_ModCode && f.keyCode == item.FC_BtnCode).FirstOrDefault();
                    if (IsHasPermsPageKeyCode == null)
                    {
                        PermsPageKeyCodeVM permsPageKeyCodeVM = new PermsPageKeyCodeVM();
                        permsPageKeyCodeVM.componetName = item.FC_ModCode;
                        permsPageKeyCodeVM.keyCode = item.FC_BtnCode;
                        permsPageKeyCodeVM.userId = userId;
                        permsPageKeyCodeVMList.Add(permsPageKeyCodeVM);
                    }
                }
                return permsPageKeyCodeVMList;
            }
        }

        public JArray GetOrganizationTree(string userId)
        {
            List<string> moduleStrList = new List<string>();
            JArray navTree = new JArray();
            using (MesDB db = new MesDB())
            {
                List<string> tbRoleList = (from z in db.TB_Sys_AccountRole.Where(f => f.FC_AcctId == userId)
                                           from g in db.TB_Sys_RoleDetail.Where(f => f.FC_RoleID == z.FC_RoleId)
                                           select g.FC_ModCode).ToList<string>();
                List<string> tbPermList = db.TB_Sys_AccountPerm.Where(f => f.FC_AcctId == userId).Select(f => f.FC_ModCode).ToList<string>();
                foreach (var item in tbRoleList)
                {
                    moduleStrList.Add(item);
                }
                foreach (var item in tbPermList)
                {
                    moduleStrList.Add(item);
                }
                List<TB_Sys_ModuleMaster> roots = new List<TB_Sys_ModuleMaster>();

                List<TB_Sys_ModuleMaster> tbModuleMaster = db.TB_Sys_ModuleMaster.Where(f => moduleStrList.Contains(f.FC_ModCode)).ToList();

                foreach (var item in tbModuleMaster)
                {
                    GetRoots(item, roots, db);
                }
                var top = from q in roots
                          where q.FC_ParentId == "0"
                          orderby q.FN_Sort
                          select q;
                foreach (var item in top)
                {
                    JArray submenlist = new JArray();
                    GetChilds(item.FC_ModCode, roots, submenlist);
                    if (submenlist.Count > 0)
                        navTree.Add(
                                  new JObject(
                                    new JProperty("id", item.FC_ModCode),
                                    new JProperty("meta", new JObject(new JProperty("title", item.FC_ModName), new JProperty("icon", item.FC_Icon))),
                                    new JProperty("path", item.FC_RTUrl),
                                    new JProperty("children", submenlist)
                                    )
                                  );
                }
            }


            return navTree;
        }


        private void GetRoots(TB_Sys_ModuleMaster child, List<TB_Sys_ModuleMaster> roots, MesDB db)
        {
            // 查询是否重复
            var IsHaschild = roots.Where(f => f.FC_ModCode == child.FC_ModCode).FirstOrDefault();
            if (IsHaschild == null)
            {
                roots.Add(child);
            }
            // 查询父节点
            TB_Sys_ModuleMaster parent = db.TB_Sys_ModuleMaster.Where(f => f.FC_ModCode == child.FC_ParentId).FirstOrDefault();
            if (parent != null)
                GetRoots(parent, roots, db);
            return;
            //if(child.FC_ParentId != "0")
            //{

            //}
            //else
            //{
            //    // 查询是否重复
            //    var IsHaschild = roots.Where(f => f.FC_ModCode == child.FC_ModCode).FirstOrDefault();
            //    if (IsHaschild == null)
            //    {
            //        roots.Add(child);
            //    }
            //    return;
            //}
        }



        private void GetChilds(string parent, List<TB_Sys_ModuleMaster> datas, JArray array)
        {
            var dd = (from d in datas
                      where d.FC_ParentId == parent
                      orderby d.FN_Sort
                      select d).ToList();
            if (dd.Count == 0)
                return;
            else
            {
                for (int i = 0; i < dd.Count; i++)
                {
                    JArray submenlist = new JArray();
                    GetChilds(dd[i].FC_ModCode, datas, submenlist);
                    //if (submenlist.Count == 0) continue;  //导航没有子权限
                    array.Add(new JObject(
                                    new JProperty("id", dd[i].FC_ModCode),
                                    new JProperty("meta", new JObject(new JProperty("title", dd[i].FC_ModName), new JProperty("icon", dd[i].FC_Icon))),
                                    new JProperty("path", dd[i].FC_RTUrl),
                                    new JProperty("children", submenlist)
                                    ));
                }
            }
        }
    }
}
