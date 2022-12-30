using Mes.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.BLL.SystemManagement.AccountManage
{
   public interface IAccountManageBLL
    {
        List<AccountVM> GetAccoutByDeptIdTable(string deptId);

        List<string> GetPermDataByAcctId(string acctId);

        bool AddOrUpdateAccountData(AccountRolePermVM accountRolePermVM);

        AccountRolePermVM GetAccountRolePermByAccountId(string acctId);

        bool DeleteAccountRolePermByAccountId(string acctId);
    }
}
