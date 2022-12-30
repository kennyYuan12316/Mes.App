using Mes.Model.ViewModel;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.BLL.SystemManagement.Role
{
   public   interface IRoleBLL
    {
        List<RoleVM> GetRoleTable();

        List<RoleVM> GetRoleDataByAcctId(string acctId);

        bool AddOrUpdateRoleData(RolePermVM roleperVM);

        List<string> GetRoleDetailTable(string roleId);

        bool DeleteRoleDataByRoleId(string roleId);
    }
}
