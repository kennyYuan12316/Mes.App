using Mes.Model.Entites;
using Mes.Model.ViewModel;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.BLL.SystemManagement.Role
{
    public class RoleBLL : IRoleBLL
    {
        public List<RoleVM> GetRoleTable()
        {
            List<RoleVM> roleVMList = new List<RoleVM>();
            using (MesDB db = new MesDB())
            {
                var roleMasterList = db.TB_Sys_RoleMaster.ToList();
                if (roleMasterList.Count > 0)
                {
                    foreach (var item in roleMasterList)
                    {
                        RoleVM rolevm = new RoleVM();
                        rolevm.roleId = item.FC_RoleID;
                        rolevm.roleName = item.FC_RoleName;
                        rolevm.createDate = item.FD_CDate;
                        rolevm.createUser = item.FC_CUser;
                        rolevm.updateDate = item.FD_UDate;
                        rolevm.updateUser = item.FC_UUser;
                        roleVMList.Add(rolevm);
                    }
                }
            }
            return roleVMList;
        }

        public List<RoleVM> GetRoleDataByAcctId(string acctId)
        {
            List<RoleVM> roleVMList = new List<RoleVM>();
            using (MesDB db = new MesDB())
            {
                var tbroleList = (from z in db.TB_Sys_AccountRole.Where(f => f.FC_AcctId == acctId)
                                  from g in db.TB_Sys_RoleMaster.Where(f => f.FC_RoleID == z.FC_RoleId)
                                  select new
                                  {
                                      z.FC_RoleId,
                                      g.FC_RoleName
                                  }).ToList();
                if (tbroleList.Count > 0)
                {
                    foreach (var item in tbroleList)
                    {
                        RoleVM rolevm = new RoleVM();
                        rolevm.roleId = item.FC_RoleId;
                        rolevm.roleName = item.FC_RoleName;
                        roleVMList.Add(rolevm);
                    }
                }
            }
            return roleVMList;
        }
        



        public bool AddOrUpdateRoleData(RolePermVM roleperVM)
        {
            bool insertFlag = false;
            using (MesDB db = new MesDB())
            {
                var RoleMaster = db.TB_Sys_RoleMaster.Where(f => f.FC_RoleID == roleperVM.roleId).FirstOrDefault();
                if (RoleMaster == null)
                {
                    TB_Sys_RoleMaster roleMasterVM = new TB_Sys_RoleMaster();
                    roleMasterVM.FC_RoleID = roleperVM.roleId;
                    roleMasterVM.FC_RoleName = roleperVM.roleName;
                    roleMasterVM.FC_UUser = roleperVM.createUser;
                    roleMasterVM.FC_CUser = roleperVM.createUser;
                    roleMasterVM.FD_CDate = DateTime.Now;
                    roleMasterVM.FD_UDate = DateTime.Now;
                    if (roleperVM.permList.Count > 0)
                    {
                        var roleDetailVM = db.TB_Sys_RoleDetail.Where(f => f.FC_RoleID == roleperVM.roleId).ToList();
                        if (roleDetailVM.Count > 0)
                        {
                            db.TB_Sys_RoleDetail.RemoveRange(roleDetailVM);
                        }
                        List<TB_Sys_RoleDetail> roleDetailList = new List<TB_Sys_RoleDetail>();
                        foreach (var item in roleperVM.permList)
                        {
                            TB_Sys_RoleDetail roleDetail = new TB_Sys_RoleDetail();
                            roleDetail.FD_CDate = DateTime.Now;
                            roleDetail.FC_CUser = roleperVM.createUser;
                            roleDetail.FC_RoleID= roleperVM.roleId;
                            roleDetail.FC_BtnCode = item.Split('_')[1];
                            roleDetail.FC_ModCode = item.Split('_')[0];
                            roleDetailList.Add(roleDetail);
                        }
                        db.TB_Sys_RoleDetail.AddRange(roleDetailList);

                    }
                    db.TB_Sys_RoleMaster.Add(roleMasterVM);
                }
                else
                {
                    RoleMaster.FC_RoleID = roleperVM.roleId;
                    RoleMaster.FC_RoleName = roleperVM.roleName;
                    RoleMaster.FC_UUser = roleperVM.createUser;
                    RoleMaster.FD_UDate = DateTime.Now;
                    if (roleperVM.permList.Count > 0)
                    {
                        var roleDetailVM = db.TB_Sys_RoleDetail.Where(f => f.FC_RoleID == roleperVM.roleId).ToList();
                        if (roleDetailVM.Count > 0)
                        {
                            db.TB_Sys_RoleDetail.RemoveRange(roleDetailVM);
                        }
                        List<TB_Sys_RoleDetail> roleDetailList = new List<TB_Sys_RoleDetail>();
                        foreach (var item in roleperVM.permList)
                        {
                            TB_Sys_RoleDetail roleDetail = new TB_Sys_RoleDetail();
                            roleDetail.FD_CDate = DateTime.Now;
                            roleDetail.FC_CUser = roleperVM.createUser;
                            roleDetail.FC_RoleID = roleperVM.roleId;
                            roleDetail.FC_BtnCode = item.Split('_')[1];
                            roleDetail.FC_ModCode = item.Split('_')[0];
                            roleDetailList.Add(roleDetail);
                        }
                        db.TB_Sys_RoleDetail.AddRange(roleDetailList);
                    }
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

        public List<string> GetRoleDetailTable(string roleId)
        {
            List<string> permList = new List<string>();
            using (MesDB db = new MesDB())
            {
                var roleDetail = db.TB_Sys_RoleDetail.Where(f => f.FC_RoleID == roleId).ToList();
                if (roleDetail.Count > 0)
                {
                    foreach (var item in roleDetail)
                    {
                        permList.Add(item.FC_ModCode + "_" + item.FC_BtnCode);
                    }
                }
            }
            return permList;
        }

        public bool DeleteRoleDataByRoleId(string roleId)
        {
            bool OpreFlag = false;
            using (MesDB db = new MesDB())
            {
                var roleMaster = db.TB_Sys_RoleMaster.Where(f => f.FC_RoleID == roleId).FirstOrDefault();
                if (roleMaster != null)
                {
                    var roleDetail = db.TB_Sys_RoleDetail.Where(f => f.FC_RoleID == roleId).ToList();
                    if (roleDetail.Count > 0)
                    {
                        db.TB_Sys_RoleDetail.RemoveRange(roleDetail);
                    }
                    db.TB_Sys_RoleMaster.Remove(roleMaster);
                }
                if (db.SaveChanges() > 0)
                {
                    OpreFlag = true;
                }
                else
                {
                    OpreFlag = false;
                }
                return OpreFlag;
            }
        }
    }
}
