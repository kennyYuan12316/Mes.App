using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.Model.ViewModel
{
   public class RoleVM
    {
        public string roleName { get; set; }

        public string roleId { get; set; }

        public string createUser { get; set; }

        public DateTime createDate { get; set; }

        public string updateUser { get; set; }

        public DateTime updateDate { get; set; }
    }
}
