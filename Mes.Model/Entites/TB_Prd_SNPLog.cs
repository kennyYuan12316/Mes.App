namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_SNPLog
    {
        [Key]
        public int FN_ID { get; set; }

        [StringLength(20)]
        public string FC_SID { get; set; }

        [StringLength(20)]
        public string FC_Factory { get; set; }

        [StringLength(20)]
        public string FC_WorkCenter { get; set; }

        [StringLength(20)]
        public string FC_LineID { get; set; }

        [StringLength(50)]
        public string FC_BatchNo { get; set; }

        [StringLength(128)]
        public string FC_SN { get; set; }

        [StringLength(50)]
        public string FC_WorkID { get; set; }

        [StringLength(20)]
        public string FC_SFCCode { get; set; }

        [StringLength(20)]
        public string FC_Status { get; set; }

        [StringLength(20)]
        public string FC_NGCode { get; set; }

        [StringLength(20)]
        public string FC_NGGroup { get; set; }

        [StringLength(250)]
        public string FC_Remark { get; set; }

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
        public string FC_CUser { get; set; }

        public DateTime? FD_CDate { get; set; }

        [StringLength(50)]
        public string FC_MaterialID { get; set; }
    }
}
