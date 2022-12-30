namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_BackNg
    {
        [Key]
        [StringLength(50)]
        public string FC_BackNgID { get; set; }

        [StringLength(50)]
        public string FC_BackNo { get; set; }

        [StringLength(50)]
        public string FC_StockID { get; set; }

        [StringLength(50)]
        public string FC_BatchNo { get; set; }

        [StringLength(20)]
        public string FC_NgGroup { get; set; }

        [StringLength(20)]
        public string FC_NGCodeNo { get; set; }

        public decimal? FN_Num { get; set; }

        [StringLength(300)]
        public string FC_Remarks { get; set; }

        public virtual TB_Prd_BackPOM TB_Prd_BackPOM { get; set; }
    }
}
