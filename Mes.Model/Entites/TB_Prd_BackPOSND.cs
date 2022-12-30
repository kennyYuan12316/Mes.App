namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_BackPOSND
    {
        [Key]
        [StringLength(50)]
        public string FC_BackSNDNo { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_PONO { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_BatchNO { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_BackNO { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_backBatchNo { get; set; }

        [Required]
        [StringLength(150)]
        public string FC_SN { get; set; }

        [StringLength(300)]
        public string FC_Remarks { get; set; }

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

        [StringLength(20)]
        public string FC_CUser { get; set; }

        public DateTime? FD_CDate { get; set; }

        [StringLength(20)]
        public string FC_UUser { get; set; }

        public DateTime? FD_UDate { get; set; }

        [StringLength(10)]
        public string FC_Status { get; set; }

        public virtual TB_Prd_BackPOM TB_Prd_BackPOM { get; set; }
    }
}
