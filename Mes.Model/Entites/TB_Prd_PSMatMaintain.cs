namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_PSMatMaintain
    {
        [Key]
        public int FC_ID { get; set; }

        [StringLength(50)]
        public string FC_Factory { get; set; }

        [StringLength(50)]
        public string FC_PNo { get; set; }

        [StringLength(50)]
        public string FC_PSCode { get; set; }

        [StringLength(50)]
        public string FC_MatNo { get; set; }

        [StringLength(50)]
        public string FC_UserName { get; set; }

        public DateTime? FD_CDate { get; set; }

        public bool? FB_Enable { get; set; }

        [StringLength(150)]
        public string FC_Remark { get; set; }

        public DateTime? FD_Update { get; set; }

        [StringLength(50)]
        public string FC_UpUser { get; set; }
    }
}
