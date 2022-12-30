namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_GetAdjMS
    {
        [StringLength(250)]
        public string FC_BarCode { get; set; }

        [StringLength(50)]
        public string FC_AJPNo { get; set; }

        [StringLength(100)]
        public string FC_Spec { get; set; }

        [StringLength(50)]
        public string FC_GetMan { get; set; }

        public int? FC_ActiveDegrees { get; set; }

        public DateTime FC_GetTime { get; set; }

        [StringLength(10)]
        public string FC_GetFlag { get; set; }

        public int? FC_RemainCount { get; set; }

        [StringLength(50)]
        public string FC_Type { get; set; }

        [StringLength(50)]
        public string FC_Factory { get; set; }

        [Key]
        [StringLength(100)]
        public string FC_ID { get; set; }

        public int? FC_ActiveTime { get; set; }

        [StringLength(50)]
        public string FC_AccessoriesName { get; set; }
    }
}
