namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_NgStoreRW
    {
        [Key]
        [StringLength(50)]
        public string FC_NgStoreRWNo { get; set; }

        [StringLength(50)]
        public string FC_PONO { get; set; }

        [StringLength(50)]
        public string FC_Unit { get; set; }

        public decimal? FN_Num { get; set; }

        [StringLength(50)]
        public string FC_PSID { get; set; }

        [StringLength(50)]
        public string FC_ERPOrder { get; set; }

        public bool? FB_ERPBGFlag { get; set; }

        public int? FN_BGCount { get; set; }

        public DateTime? FD_ERPBGDate { get; set; }

        [StringLength(50)]
        public string FC_ERPBGNo { get; set; }

        [StringLength(50)]
        public string FC_ERPBGCount { get; set; }
    }
}
