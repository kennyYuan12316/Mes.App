using Mes.Model.Entites;
using Mes.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.BLL.Login
{
    public interface ILoginBLL
    {
        UserProfileVM Login(UserProfileVM userProfileVM);

        UserProfileVM GetUserInfo(string userId);
    }
}
