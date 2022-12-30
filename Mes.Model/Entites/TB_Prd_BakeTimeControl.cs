namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_BakeTimeControl
    {
        [Key]
        public int FN_ID { get; set; }

        [StringLength(50)]
        public string FC_Factory { get; set; }

        [StringLength(50)]
        public string FC_BatchNo { get; set; }

        [StringLength(50)]
        public string FC_PSCode { get; set; }

        [StringLength(50)]
        public string FC_PSName { get; set; }

        [StringLength(50)]
        public string FC_LineID { get; set; }

        [StringLength(50)]
        public string FC_Machine { get; set; }

        [StringLength(150)]
        public string FC_Shape { get; set; }

        [StringLength(50)]
        public string FC_WorkCenter { get; set; }

        [StringLength(50)]
        public string UserID { get; set; }

        public DateTime? FD_StartTime { get; set; }

        public DateTime? FD_EndTime { get; set; }

        public int? FN_StandBakeTime { get; set; }

        public int? FN_RealityBakeTime { get; set; }
    }
}
