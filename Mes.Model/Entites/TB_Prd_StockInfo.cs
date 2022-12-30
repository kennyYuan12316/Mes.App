namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_StockInfo
    {
        [Key]
        [StringLength(50)]
        public string FC_ChgID { get; set; }

        [StringLength(50)]
        public string FC_ID { get; set; }

        [StringLength(20)]
        public string FC_ChgType { get; set; }

        public decimal? FN_ChgNums { get; set; }

        public DateTime? FD_ChgDate { get; set; }

        [StringLength(50)]
        public string FC_BillNo { get; set; }

        public virtual TB_Prd_Stocks TB_Prd_Stocks { get; set; }
    }
}
