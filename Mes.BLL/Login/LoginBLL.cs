using Mes.Common;
using Mes.Common.Encrypt;
using Mes.Model.Entites;
using Mes.Model.ViewModel;
using System;
using System.Linq;
using System.Web;

namespace Mes.BLL.Login
{
    public class LoginBLL : ILoginBLL
    {
        public UserProfileVM GetUserInfo(string userId)
        {
            using (MesDB db = new MesDB())
            {
                var userInfo = (from m in db.TB_Sys_Account.Where(f => f.FC_AcctId == userId)
                                select new UserProfileVM
                                {
                                    userId = m.FC_AcctId,
                                    password = m.FC_Password,
                                    userName = m.FC_Name,
                                    deptId = m.FC_DeptId,
                                }).FirstOrDefault();
                if (userInfo == null)
                {
                    throw new Exception("10000");
                }
                return userInfo;
            }
        }

        public UserProfileVM Login(UserProfileVM userProfileVM)
        {
            using (MesDB db = new MesDB())
            {
                //var userInfo = (from m in db.TB_SYS_UserInfo.Where(f=> f.FC_UserID == userProfileVM.userId)
                //                from z in db.TB_HR_Employees.Where(f => f.FC_EmpCode == m.FC_UserID)
                //                select new UserProfileVM
                //                {
                //                    userId= m.FC_UserID,
                //                    password= m.FC_Password,
                //                    userName= z.FC_Name,
                //                    factoryId = z.FC_DeptID,
                //                    passwordType=m.FC_PasswordType
                //                }).FirstOrDefault();
                //if (userInfo == null)
                //{
                //    throw GlobalException.message("10000", userProfileVM.userId);
                //}
                //string passwordType = userInfo.passwordType;
                //string password = DESEncodeDecode.Decode(userInfo.password);
                var acctInfo = db.TB_Sys_Account.Where(f => f.FC_AcctId == userProfileVM.userId).FirstOrDefault();
                if (acctInfo == null)
                {
                    throw GlobalException.message("10000", userProfileVM.userId);
                }

                if (!acctInfo.FC_Password.Equals(userProfileVM.password))
                {
                    throw GlobalException.message("10001");
                }
                userProfileVM.userName = acctInfo.FC_Name;
                userProfileVM.deptId = acctInfo.FC_DeptId;
                return userProfileVM;
            }
        }
    }
}
