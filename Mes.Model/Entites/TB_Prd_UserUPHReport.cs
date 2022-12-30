namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_UserUPHReport
    {
        [Key]
        public int FN_ID { get; set; }

        [StringLength(50)]
        public string FC_UserID { get; set; }

        public decimal? FN_SumQTY { get; set; }

        public decimal? FN_GoodQTY { get; set; }

        public decimal? FN_NGQTY { get; set; }

        public decimal? FN_RepairtQTY { get; set; }

        public decimal? FN_RepeatQTY { get; set; }

        public decimal? FN_StanderOfflineQTY { get; set; }

        public decimal? FD_CDate { get; set; }

        [StringLength(50)]
        public string FC_PSCode { get; set; }

        [StringLength(50)]
        public string FC_PoNo { get; set; }

        [StringLength(50)]
        public string FC_Shape { get; set; }

        [StringLength(50)]
        public string FC_PNo { get; set; }
    }
}
