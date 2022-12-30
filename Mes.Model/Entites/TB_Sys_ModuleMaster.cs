using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Mes.Model.Entites
{
    public partial class TB_Sys_ModuleMaster
    {
        [Key]
        public int FN_ID { get; set; }

        [StringLength(50)]
        public string FC_ModCode { get; set; }

        [StringLength(50)]
        public string FC_ModName { get; set; }

        [StringLength(50)]
        public string FC_Icon { get; set; }

        [StringLength(100)]
        public string FC_RTUrl { get; set; }

        public int FN_Sort { get; set; }

        [StringLength(50)]
        public string FC_ParentId { get; set; }

        public bool FB_Enable { get; set; }

        public DateTime FD_CDate { get; set; }

        public DateTime FD_UDate { get; set; }

        [StringLength(50)]
        public string FC_CUser { get; set; }

        [StringLength(50)]
        public string FC_UUser { get; set; }

        [StringLength(250)]
        public string FC_Desc { get; set; }
    }
}
