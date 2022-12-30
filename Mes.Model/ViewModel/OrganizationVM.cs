using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.Model.ViewModel
{
   public class OrganizationVM
    {
        public string deptId { get; set; }

        public string deptName { get; set; }

        public bool status { get; set; }
        public string parentId { get; set; }

        public string createUser { get; set; }

        public string remark { get; set; }

    }
}
