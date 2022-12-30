using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.Model.ViewModel
{
  public  class AccountRolePermVM
    {
        public AccountRolePermVM()
        {
            roleList = new List<string>();
            acctOprsList = new List<string>();
        }
        public string acctName { get; set; }

        public string acctId { get; set; }

        public string phone { get; set; }

        public string email { get; set; }

        public string image { get; set; }

        public bool gender { get; set; }

        public bool status { get; set; }

        public string deptId { get; set; }

        public string createUser { get; set; }

        public List<string> roleList { get; set; }

        public List<string> acctOprsList { get; set; }
    }
}
