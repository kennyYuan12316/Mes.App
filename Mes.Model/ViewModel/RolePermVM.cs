using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.Model.ViewModel
{
    public class RolePermVM
    {
        public RolePermVM()
        {
            permList = new List<string>();
        }
        public string roleName { get; set; }

        public string roleId { get; set; }

        public string createUser { get; set; }

        public DateTime createDate { get; set; }

        public string updateUser { get; set; }

        public DateTime updateDate { get; set; }

        public List<string> permList { get; set; }
    }
}
