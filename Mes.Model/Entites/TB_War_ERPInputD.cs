namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_War_ERPInputD
    {
        [Key]
        [StringLength(50)]
        public string FC_WarDNo { get; set; }

        [StringLength(50)]
        public string FC_INNo { get; set; }

        [StringLength(50)]
        public string FC_ID { get; set; }

        [StringLength(50)]
        public string FC_PNo { get; set; }

        [StringLength(50)]
        public string FC_PVer { get; set; }

        [StringLength(300)]
        public string FC_PName { get; set; }

        [StringLength(300)]
        public string FC_Shape { get; set; }

        [Required]
        [StringLength(100)]
        public string FC_BatchCode { get; set; }

        [StringLength(50)]
        public string FC_PONo { get; set; }

        [StringLength(50)]
        public string FC_SONo { get; set; }

        [StringLength(50)]
        public string FC_ERPPO { get; set; }

        public decimal? FN_SubNums { get; set; }

        public decimal? FN_RecNums { get; set; }

        [StringLength(50)]
        public string FC_Unit { get; set; }

        [StringLength(300)]
        public string FC_Remarks { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_BatchNo { get; set; }

        public virtual TB_Prd_Stocks TB_Prd_Stocks { get; set; }

        public virtual TB_War_ERPInput TB_War_ERPInput { get; set; }
    }
}
