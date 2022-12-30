namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_WIP_POBatchLog
    {
        [Key]
        public int FN_ID { get; set; }

        [StringLength(20)]
        public string FN_SID { get; set; }

        public DateTime? FD_RegTime { get; set; }

        public int? FN_PlanNum { get; set; }

        public int? FN_NBox { get; set; }

        public int? FN_WBox { get; set; }

        public int? FN_RealNum { get; set; }

        public int? FN_RealNBox { get; set; }

        public int? FN_RealWBox { get; set; }

        [StringLength(1)]
        public string FC_Status { get; set; }

        public int? FN_PNum { get; set; }

        [StringLength(150)]
        public string FC_SID { get; set; }

        [StringLength(20)]
        public string FC_StopDeptID { get; set; }

        [StringLength(50)]
        public string FC_UDF01 { get; set; }

        [StringLength(50)]
        public string FC_UDF02 { get; set; }

        [StringLength(50)]
        public string FC_UDF03 { get; set; }

        [StringLength(250)]
        public string FC_UDF04 { get; set; }

        [StringLength(250)]
        public string FC_UDF05 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FN_UDF51 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FN_UDF52 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FN_UDF53 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FN_UDF54 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FN_UDF55 { get; set; }

        [StringLength(20)]
        public string FC_CUserID { get; set; }

        public DateTime? FC_CDate { get; set; }
    }
}
