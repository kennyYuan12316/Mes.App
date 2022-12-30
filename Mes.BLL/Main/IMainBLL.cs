using Mes.Model.ViewModel;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.BLL.Main
{
    public interface IMainBLL
    {

        JArray GetOrganizationTree(string userId);

        List<PermsPageKeyCodeVM> GetComponentBtnPower(string componetName, string userId);
    }
}
