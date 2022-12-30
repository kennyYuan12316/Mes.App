namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_ProdTran
    {
        [Key]
        [StringLength(50)]
        public string FC_PTranID { get; set; }

        [StringLength(50)]
        public string FC_ProdID { get; set; }

        [StringLength(20)]
        public string FC_ProdFlag { get; set; }

        [StringLength(50)]
        public string FC_TrPS { get; set; }

        [StringLength(50)]
        public string FC_TrPSCode { get; set; }

        public DateTime? FD_TrDate { get; set; }

        [StringLength(50)]
        public string FC_TrUser { get; set; }

        public virtual TB_Prd_POBatchProd TB_Prd_POBatchProd { get; set; }
    }
}
