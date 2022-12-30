namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_ArrangeInfo
    {
        public int ID { get; set; }

        public decimal? FC_EditionNums { get; set; }

        public decimal? FC_Material { get; set; }

        [StringLength(50)]
        public string FC_PeculiarCraft { get; set; }

        public int? FC_PlanGrade { get; set; }

        [StringLength(50)]
        public string FC_PONo { get; set; }

        [StringLength(50)]
        public string FC_Remarks { get; set; }

        [StringLength(50)]
        public string FC_Remarks1 { get; set; }

        [StringLength(50)]
        public string FC_Remarks2 { get; set; }

        [StringLength(50)]
        public string FC_Remarks3 { get; set; }

        [StringLength(50)]
        public string FC_Remarks4 { get; set; }

        public decimal? FC_SuccessProduct { get; set; }

        [StringLength(50)]
        public string FC_UrgencyRemarks { get; set; }
    }
}
