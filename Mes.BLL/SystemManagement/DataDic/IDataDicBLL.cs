using Mes.Model.ViewModel;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.BLL.SystemManagement.DataDic
{
   public interface IDataDicBLL
    {
        JArray GetDataDicTree();


        List<DataDicVM> GetDataDicTable(string dicType);

        List<DataDicDetailVM> GetDataDicDetailTable(string dicCode);

        bool AddOrUpdateDataDic(DataDicAndDetailVM datDicAndDetail);

        DataDicAndDetailVM GetDataDicBydicCode(string dicCode);


        bool DeleteDataDicByDicCode(string dicCode);

        



    }
}
