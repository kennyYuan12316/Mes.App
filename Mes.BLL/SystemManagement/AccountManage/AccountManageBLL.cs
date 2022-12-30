using Mes.Model.Entites;
using Mes.Model.ViewModel;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.BLL.SystemManagement.AccountManage
{
    public class AccountManageBLL : IAccountManageBLL
    {
        public bool AddOrUpdateAccountData(AccountRolePermVM accountRolePermVM)
        {
            bool result = false;
            List<TB_Sys_AccountRole> accountRoleList = new List<TB_Sys_AccountRole>();
            List<TB_Sys_AccountPerm> accountPermList = new List<TB_Sys_AccountPerm>();
            using (MesDB db = new MesDB())
            {
                var acct = db.TB_Sys_Account.Where(f => f.FC_AcctId == accountRolePermVM.acctId).FirstOrDefault();
                if (acct == null)
                {
                    TB_Sys_Account tbAcct = new TB_Sys_Account();
                    tbAcct.FC_Name = accountRolePermVM.acctName;
                    tbAcct.FB_Gender = accountRolePermVM.gender;
                    tbAcct.FC_AcctId = accountRolePermVM.acctId;
                    tbAcct.FC_DeptId = accountRolePermVM.deptId;
                    tbAcct.FC_Email = accountRolePermVM.email;
                    tbAcct.FC_Phone = accountRolePermVM.phone;
                    tbAcct.FC_Password = "000000";
                    tbAcct.FB_Status = accountRolePermVM.status;
                    tbAcct.FC_Image = accountRolePermVM.image;
                    tbAcct.FC_CUser = accountRolePermVM.createUser;
                    tbAcct.FD_CDate = DateTime.Now;
                    tbAcct.FC_UUser = accountRolePermVM.createUser;
                    tbAcct.FD_UDate = DateTime.Now;
                    db.TB_Sys_Account.Add(tbAcct);
                    var roleData = db.TB_Sys_AccountRole.Where(f => f.FC_AcctId == accountRolePermVM.acctId).ToList();
                    if (roleData.Count > 0)
                    {
                        db.TB_Sys_AccountRole.RemoveRange(roleData);
                    }

                    if (accountRolePermVM.roleList.Count > 0)
                    {
                        foreach (var item in accountRolePermVM.roleList)
                        {
                            TB_Sys_AccountRole tbActRole = new TB_Sys_AccountRole();
                            tbActRole.FC_AcctId = accountRolePermVM.acctId;
                            tbActRole.FC_CUser = accountRolePermVM.createUser;
                            tbActRole.FC_RoleId = item;
                            tbActRole.FD_CDate = DateTime.Now;
                            tbActRole.FC_CUser = accountRolePermVM.createUser;
                            accountRoleList.Add(tbActRole);
                        }
                        db.TB_Sys_AccountRole.AddRange(accountRoleList);
                    }
                    var oprData = db.TB_Sys_AccountPerm.Where(f => f.FC_AcctId == accountRolePermVM.acctId).ToList();
                    if (oprData.Count > 0)
                    {
                        db.TB_Sys_AccountPerm.RemoveRange(oprData);
                    }

                    if (accountRolePermVM.acctOprsList.Count > 0)
                    {
                        foreach (var item in accountRolePermVM.acctOprsList)
                        {
                            TB_Sys_AccountPerm tbAcctPerm = new TB_Sys_AccountPerm();
                            tbAcctPerm.FC_AcctId = accountRolePermVM.acctId;
                            tbAcctPerm.FC_CUser = accountRolePermVM.createUser;
                            tbAcctPerm.FC_ModCode = item.Split('_')[0];
                            tbAcctPerm.FC_BtnCode = item.Split('_')[1];
                            tbAcctPerm.FD_CDate = DateTime.Now;
                            tbAcctPerm.FC_CUser = accountRolePermVM.createUser;
                            accountPermList.Add(tbAcctPerm);
                        }
                        db.TB_Sys_AccountPerm.AddRange(accountPermList);
                    }
                }
                else
                {
                    acct.FC_Name = accountRolePermVM.acctName;
                    acct.FB_Gender = accountRolePermVM.gender;
                    acct.FC_AcctId = accountRolePermVM.acctId;
                    acct.FC_DeptId = accountRolePermVM.deptId;
                    acct.FC_Email = accountRolePermVM.email;
                    acct.FC_Phone = accountRolePermVM.phone;
                    acct.FB_Status = accountRolePermVM.status;
                    acct.FC_Image = accountRolePermVM.image;
                    acct.FC_UUser = accountRolePermVM.createUser;
                    acct.FD_UDate = DateTime.Now;

                    var roleData = db.TB_Sys_AccountRole.Where(f => f.FC_AcctId == accountRolePermVM.acctId).ToList();
                    if (roleData.Count > 0)
                    {
                        db.TB_Sys_AccountRole.RemoveRange(roleData);
                    }

                    if (accountRolePermVM.roleList.Count > 0)
                    {
                        foreach (var item in accountRolePermVM.roleList)
                        {
                            TB_Sys_AccountRole tbActRole = new TB_Sys_AccountRole();
                            tbActRole.FC_AcctId = accountRolePermVM.acctId;
                            tbActRole.FC_CUser = accountRolePermVM.createUser;
                            tbActRole.FC_RoleId = item;
                            tbActRole.FD_CDate = DateTime.Now;
                            tbActRole.FC_CUser = accountRolePermVM.createUser;
                            accountRoleList.Add(tbActRole);
                        }
                        db.TB_Sys_AccountRole.AddRange(accountRoleList);
                    }
                    var oprData = db.TB_Sys_AccountPerm.Where(f => f.FC_AcctId == accountRolePermVM.acctId).ToList();

                    if (oprData.Count > 0)
                    {
                        db.TB_Sys_AccountPerm.RemoveRange(oprData);
                    }

                    if (accountRolePermVM.acctOprsList.Count > 0)
                    {
                        foreach (var item in accountRolePermVM.acctOprsList)
                        {
                            TB_Sys_AccountPerm tbAcctPerm = new TB_Sys_AccountPerm();
                            tbAcctPerm.FC_AcctId = accountRolePermVM.acctId;
                            tbAcctPerm.FC_CUser = accountRolePermVM.createUser;
                            tbAcctPerm.FC_ModCode = item.Split('_')[0];
                            tbAcctPerm.FC_BtnCode = item.Split('_')[1];
                            tbAcctPerm.FD_CDate = DateTime.Now;
                            tbAcctPerm.FC_CUser = accountRolePermVM.createUser;
                            accountPermList.Add(tbAcctPerm);
                        }
                        db.TB_Sys_AccountPerm.AddRange(accountPermList);
                    }
                }
                if (db.SaveChanges() > 0)
                {
                    result = true;
                }
                return result;
            }
        }

        public bool DeleteAccountRolePermByAccountId(string acctId)
        {
            bool result = false;
            using (MesDB db = new MesDB())
            {
                var tbAccount = db.TB_Sys_Account.Where(f => f.FC_AcctId == acctId).FirstOrDefault();
                if (tbAccount != null)
                {
                    var tbAccountPermList = db.TB_Sys_AccountPerm.Where(f => f.FC_AcctId == acctId).ToList();
                    if (tbAccountPermList.Count > 0)
                    {
                        db.TB_Sys_AccountPerm.RemoveRange(tbAccountPermList);
                    }
                    var tbAccountRoleList = db.TB_Sys_AccountRole.Where(f => f.FC_AcctId == acctId).ToList();
                    if (tbAccountRoleList.Count > 0)
                    {
                        db.TB_Sys_AccountRole.RemoveRange(tbAccountRoleList);
                    }
                    db.TB_Sys_Account.Remove(tbAccount);
                }
                if (db.SaveChanges() > 0)
                {
                    result = true;
                }
                return result;
            }
        }

        public AccountRolePermVM GetAccountRolePermByAccountId(string acctId)
        {
            AccountRolePermVM accountRolePermVM = new AccountRolePermVM();
            using (MesDB db = new MesDB())
            {
                var tbAccount = db.TB_Sys_Account.Where(f => f.FC_AcctId == acctId).FirstOrDefault();
                if (tbAccount != null)
                {
                    accountRolePermVM.acctId = tbAccount.FC_AcctId;
                    accountRolePermVM.acctName = tbAccount.FC_Name;
                    accountRolePermVM.deptId = tbAccount.FC_DeptId;
                    accountRolePermVM.email = tbAccount.FC_Email;
                    accountRolePermVM.gender = tbAccount.FB_Gender;
                    accountRolePermVM.image = tbAccount.FC_Image;
                    accountRolePermVM.phone = tbAccount.FC_Phone;
                    accountRolePermVM.status = tbAccount.FB_Status;
                    var tbAcctRole = db.TB_Sys_AccountRole.Where(f => f.FC_AcctId == acctId).ToList();
                    if (tbAcctRole.Count>0)
                    {
                        foreach (var item in tbAcctRole)
                        {
                            accountRolePermVM.roleList.Add(item.FC_RoleId);
                        }

                    }
                    var tbAcctPerm = db.TB_Sys_AccountPerm.Where(f => f.FC_AcctId == acctId).ToList();
                    if (tbAcctPerm.Count > 0)
                    {
                        foreach (var item in tbAcctPerm)
                        {
                            accountRolePermVM.acctOprsList.Add(item.FC_ModCode + "_" + item.FC_BtnCode);
                        }
                    }

                }
                return accountRolePermVM;
            }
        }

        public List<AccountVM> GetAccoutByDeptIdTable(string deptId)
        {
            List<AccountVM> accountVMList = new List<AccountVM>();
            using (MesDB db = new MesDB())
            {
                var accountList = db.TB_Sys_Account.Where(f => f.FC_DeptId == deptId).ToList();
                if (accountList.Count > 0)
                {
                    foreach (var item in accountList)
                    {
                        AccountVM accountVM = new AccountVM();
                        accountVM.acctId = item.FC_AcctId;
                        accountVM.acctName = item.FC_Name;
                        accountVM.deptId = item.FC_DeptId;
                        accountVM.email = item.FC_Email;
                        accountVM.gender = item.FB_Gender;
                        accountVM.image = item.FC_Image;
                        accountVM.status = item.FB_Status;
                        accountVM.phone = item.FC_Phone;
                        accountVMList.Add(accountVM);
                    }
                }
                return accountVMList;
            }
        }

        public List<string> GetPermDataByAcctId(string acctId)
        {
            List<string> permList = new List<string>();
            using (MesDB db = new MesDB())
            {
                var tbPermList = db.TB_Sys_AccountPerm.Where(f => f.FC_AcctId == acctId).ToList();
                if (tbPermList.Count > 0)
                {
                    foreach (var item in tbPermList)
                    {
                        permList.Add(item.FC_ModCode + "_" + item.FC_BtnCode);
                    }
                }

                return permList;
            }

        }



    }
}
