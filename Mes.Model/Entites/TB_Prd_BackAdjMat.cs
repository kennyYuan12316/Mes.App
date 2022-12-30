namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_BackAdjMat
    {
        [StringLength(250)]
        public string FC_BarCode { get; set; }

        [StringLength(50)]
        public string FC_AJPNo { get; set; }

        [StringLength(50)]
        public string FC_BackMan { get; set; }

        public DateTime? FC_BackTime { get; set; }

        [StringLength(50)]
        public string FC_Factory { get; set; }

        [StringLength(50)]
        public string FC_Remark { get; set; }

        public int? FC_BackCount { get; set; }

        [Key]
        [StringLength(100)]
        public string FC_ID { get; set; }
    }
}
