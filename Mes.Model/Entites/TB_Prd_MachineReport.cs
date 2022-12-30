namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_MachineReport
    {
        [StringLength(4)]
        public string FC_Factory { get; set; }

        [StringLength(50)]
        public string FC_SFCCode { get; set; }

        [StringLength(50)]
        public string MachineNumber { get; set; }

        [StringLength(50)]
        public string FD_CDate { get; set; }

        public int? TestCount { get; set; }

        public int? InputNum { get; set; }

        public double? RepeatPer { get; set; }

        public int? OKNumber { get; set; }

        public int? NGNumber { get; set; }

        public double? YieldPer { get; set; }

        [Key]
        public int FC_ID { get; set; }
    }
}
