using Mes.Model.CommModel;
using Mes.Model.Entites;
using Mes.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.BLL.Comm
{
  public static  class DictDetailComm
    {
        public static List<DataDicDetailVM> GetDictDetailForDicCode(string dicCode)
        {
            using (MesDB db = new MesDB())
            {
                List<DataDicDetailVM> detailVMList = new List<DataDicDetailVM>();
                var tbDataDict = db.TB_Sys_DataDictionaryDetail.Where(f => f.FC_DicCode == dicCode).ToList();
                return tbDataDict.EntityConvert<TB_Sys_DataDictionaryDetail, DataDicDetailVM>();
            }
        }
    }
}
