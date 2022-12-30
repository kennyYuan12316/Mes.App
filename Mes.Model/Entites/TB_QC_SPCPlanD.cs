namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_QC_SPCPlanD
    {
        [Key]
        [StringLength(50)]
        public string FC_PItemId { get; set; }

        [StringLength(50)]
        public string FC_PId { get; set; }

        [StringLength(50)]
        public string FC_CheckNo { get; set; }

        public int? FN_Order { get; set; }

        public decimal? FN_GCCK { get; set; }

        public decimal? FN_SPC { get; set; }

        public decimal? FN_XPC { get; set; }

        public decimal? FN_JXZ { get; set; }

        public decimal? FN_ZJZ { get; set; }

        public decimal? FN_JDZ { get; set; }

        public virtual TB_Pub_QCParms TB_Pub_QCParms { get; set; }

        public virtual TB_QC_RPCPlan TB_QC_RPCPlan { get; set; }
    }
}
