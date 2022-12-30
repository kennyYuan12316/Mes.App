using Mes.Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.BLL.Comm
{
 public static class ExceptionComm
    {
        public static string HandException(string code,string lang, params string[] param)
        {
            using (MesDB db = new MesDB())
            {
                int ID = int.Parse(code);
                var messageInfo = db.TB_Pub_NoticeMessage.Where(f => f.FN_ID == ID && f.FC_Lang == lang).FirstOrDefault();
                if (messageInfo == null)
                {
                    return string.Format("请联系管理员，{0}", code);
                }
                if(messageInfo.FN_ParaNum == 0)
                {
                    return messageInfo.FC_Message;
                }
                return string.Format(messageInfo.FC_Message,param);
            }
        }
    }
}
