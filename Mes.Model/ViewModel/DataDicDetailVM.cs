using Mes.Model.CommModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.Model.ViewModel
{
   public class DataDicDetailVM
    {
        [Mapper("FC_PK")]
        public string pk { get; set; }

        [Mapper("FC_PN")]
        public string pn { get; set;}

        [Mapper("FN_Sort")]
        public int sort { get; set; }

        [Mapper("FC_V1")]
        public string v1 { get; set;}
        [Mapper("FC_V2")]
        public string v2 { get; set; }
        [Mapper("FC_V3")]
        public string v3 { get; set; }
        [Mapper("FC_V4")]
        public string v4 { get; set; }
        [Mapper("FC_V5")]
        public string v5 { get; set; }
        [Mapper("FC_V6")]
        public string v6 { get; set; }
        [Mapper("FD_CDate")]
        public DateTime createDate { get; set; }
        [Mapper("FC_CUser")]
        public string createUserId { get; set; }
    }
}
