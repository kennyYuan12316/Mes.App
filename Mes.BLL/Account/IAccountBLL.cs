using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.BLL.Account
{
    public interface IAccountBLL
    {
        bool ExistUser(string userId);
    }
}
