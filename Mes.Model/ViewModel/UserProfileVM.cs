using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.Model.ViewModel
{
    /// <summary>
    /// 用户信息实体
    /// </summary>
  public  class UserProfileVM
    {
        public string userId { get; set; }

        public string userName { get; set; }

        public string deptId { get; set; }

        public string password { get; set; }

        public string passwordType { get; set; }
    }
}
