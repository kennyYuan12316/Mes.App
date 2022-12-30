using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.Model.ViewModel
{
    public class DataDicVM
    {
        public string dicCode { get; set; }

        public string dicName { get; set; }

        public string dicType { get; set; }

        public bool status { get; set; }

        public DateTime createDate { get; set; }

        public DateTime updateDate { get; set; }

        public string createUserId { get; set;}

        public string updateUserId { get; set; }


    }
}
