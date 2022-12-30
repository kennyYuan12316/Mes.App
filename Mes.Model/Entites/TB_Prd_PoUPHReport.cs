namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_PoUPHReport
    {
        [Key]
        public int FN_ID { get; set; }

        [StringLength(50)]
        public string FC_PoNo { get; set; }

        [StringLength(50)]
        public string FC_PSCode { get; set; }

        [StringLength(4)]
        public string FC_Factory { get; set; }

        public decimal? FN_PoStanderQTY { get; set; }

        public decimal? FN_PoOfflineQTY { get; set; }

        public decimal? FN_RemainQTY { get; set; }

        [StringLength(50)]
        public string FC_PoOfflineYeild { get; set; }

        [StringLength(150)]
        public string FC_Shape { get; set; }

        [StringLength(50)]
        public string FC_PNo { get; set; }

        public DateTime? FD_CDate { get; set; }

        [StringLength(50)]
        public string FC_CUserID { get; set; }

        public DateTime? FD_UDate { get; set; }

        [StringLength(50)]
        public string FC_UUserD { get; set; }

        [StringLength(50)]
        public string FC_PSName { get; set; }

        public decimal? FN_RepairIn { get; set; }

        public decimal? FN_RepairOut { get; set; }

        public decimal? FN_BackQTY { get; set; }

        public decimal? FN_RepairOffline { get; set; }

        public decimal? FN_CustBackQTY { get; set; }

        public decimal? FN_CustOfflineQTY { get; set; }
    }
}
