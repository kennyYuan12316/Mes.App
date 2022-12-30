namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_WIP_POBatchMats
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FN_ID { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string FN_SID { get; set; }

        [Required]
        [StringLength(1)]
        public string FC_Type { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string FC_Item { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string FC_BarCode { get; set; }

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
    }
}
