namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_DayPlanD
    {
        [Key]
        [StringLength(50)]
        public string FC_PlanDNo { get; set; }

        [StringLength(50)]
        public string FC_PlanNo { get; set; }

        [StringLength(50)]
        public string FC_Code { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_PONo { get; set; }

        public decimal? FN_PlanNums { get; set; }

        [StringLength(50)]
        public string FC_Lvl { get; set; }

        [StringLength(50)]
        public string FC_MatStatus { get; set; }

        public decimal? FN_FNums { get; set; }

        [StringLength(300)]
        public string FC_Remarks { get; set; }

        [StringLength(300)]
        public string FC_Feedback { get; set; }

        [StringLength(20)]
        public string FC_RecType { get; set; }

        public decimal? FN_FOutNums { get; set; }

        public decimal? FN_Per { get; set; }

        public virtual TB_Prd_DayPlan TB_Prd_DayPlan { get; set; }
    }
}
