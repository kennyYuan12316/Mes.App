using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.Model.ViewModel
{
   public class PermsPageKeyCodeVM
    {
        /// <summary>
        /// 组件名称
        /// </summary>
        public string componetName { get; set; }
        /// <summary>
        /// 按钮事件权限
        /// </summary>
        public string keyCode { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public string userId { get; set; }
    }
}
