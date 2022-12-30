namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_NGSplitDetial
    {
        [Key]
        [StringLength(50)]
        public string FC_DID { get; set; }

        [StringLength(50)]
        public string FC_NGSplitNo { get; set; }

        public decimal? FN_Nums { get; set; }

        [StringLength(50)]
        public string FC_StockID { get; set; }

        [StringLength(20)]
        public string FC_PType { get; set; }

        [StringLength(20)]
        public string FC_NGCodeNo { get; set; }

        [StringLength(50)]
        public string FC_PSNo { get; set; }

        [StringLength(50)]
        public string FC_NGGroup { get; set; }

        [StringLength(300)]
        public string FC_Remarks { get; set; }

        public virtual TB_Prd_NGSplitMain TB_Prd_NGSplitMain { get; set; }
    }
}
