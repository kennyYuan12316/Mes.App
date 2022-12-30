using Mes.Model.CommModel;
using Mes.Model.Entites;
using Mes.Model.ViewModel;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.BLL.SystemManagement.Module
{
    public interface IModuleBLL
    {
        bool AddOrUpdateModuleData(ModuleVM moduleData);
        ModuleVM GetModuleById(string moduleId);
        JArray GetModuleTree();

        List<ModuleVM> GetModuleTable(string parentId, int page, int size, ref int total);

        List<KeyValuePair> GetDictDetailForDicCode(string catCode);

        bool DeleteModuleDataByModuleId(string modCode);

        JArray GetModuleDetailTree(bool disableStatus);

       


    }
}
