using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.DAL.Login
{
   public interface ILoginDAL
    {
        bool Login(string username, string pwd);
    }
}
