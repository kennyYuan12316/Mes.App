namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_NGSplitOutD
    {
        [Key]
        [StringLength(50)]
        public string FC_DID { get; set; }

        [StringLength(50)]
        public string FC_SplitOutNo { get; set; }

        [StringLength(50)]
        public string FC_MatNo { get; set; }

        [StringLength(200)]
        public string FC_Shape { get; set; }

        [StringLength(20)]
        public string FC_PType { get; set; }

        [StringLength(50)]
        public string FC_WarType { get; set; }

        [StringLength(50)]
        public string FC_WarNo { get; set; }

        public decimal? FN_Nums { get; set; }

        [StringLength(50)]
        public string FC_StockID { get; set; }

        [StringLength(50)]
        public string FC_SourceStockID { get; set; }

        [StringLength(300)]
        public string FC_Remarks { get; set; }

        public virtual TB_Prd_NGSplitOutM TB_Prd_NGSplitOutM { get; set; }
    }
}
