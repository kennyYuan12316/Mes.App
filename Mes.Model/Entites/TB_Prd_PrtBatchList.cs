namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_PrtBatchList
    {
        [Key]
        [StringLength(50)]
        public string FC_BID { get; set; }

        [StringLength(50)]
        public string FC_PrtID { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_BatchNo { get; set; }

        public decimal? FN_PackNum { get; set; }

        public virtual TB_Pck_PrtRec TB_Pck_PrtRec { get; set; }
    }
}
