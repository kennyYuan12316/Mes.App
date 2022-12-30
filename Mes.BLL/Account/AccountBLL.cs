using Mes.Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.BLL.Account
{
    public class AccountBLL : IAccountBLL
    {
        public bool ExistUser(string userId)
        {
            try
            {
                using (MesDB mesDB = new MesDB())
                {
                    var user = mesDB.TB_SYS_UserInfo.Where(f => f.FC_UserID == userId).FirstOrDefault();
                    if (user == null)
                    {
                        
                        return false;
                    }
                    
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
