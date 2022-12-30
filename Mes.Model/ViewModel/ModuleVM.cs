using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.Model.ViewModel
{
   public class ModuleVM
    {
        public ModuleVM()
        {
            btnArr = new string[] { };
        }
        public string modCode { get; set; }

        public string modName { get; set; }

        public string icon { get; set; }

        public string rtUrl { get; set; }

        public int sort { get; set;   }

        public string parentId { get; set; }

        public bool status { get; set; }

        public string desc { get; set; }

        public string userId { get; set; }

        public string[] btnArr { get; set; }

        public DateTime createDate { get; set; }

        public DateTime updateDate { get; set; }

        public string createUserId { get; set; }

        public string updateUserId { get; set;}
    }
}
