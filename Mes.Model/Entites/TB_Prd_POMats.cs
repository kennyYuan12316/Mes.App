namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_POMats
    {
        [Key]
        [StringLength(50)]
        public string FC_POMatNo { get; set; }

        [StringLength(50)]
        public string FC_PONo { get; set; }

        [StringLength(50)]
        public string FC_MatNo { get; set; }

        [StringLength(200)]
        public string FC_MatName { get; set; }

        [StringLength(200)]
        public string FC_Shape { get; set; }

        [StringLength(50)]
        public string FC_RDNo { get; set; }

        public decimal? FN_Nums { get; set; }

        public decimal? FN_PerOne { get; set; }

        [StringLength(50)]
        public string FC_Units { get; set; }

        public DateTime? FD_CDate { get; set; }

        [StringLength(300)]
        public string FC_Remarks { get; set; }

        [StringLength(50)]
        public string FC_MatTNo { get; set; }

        [StringLength(50)]
        public string FC_ERPMatTNo { get; set; }

        [StringLength(200)]
        public string FC_ERPMatTName { get; set; }

        public int? FN_ERPOrder { get; set; }

        [StringLength(50)]
        public string FC_ERPWarNo { get; set; }

        [StringLength(50)]
        public string FC_ERPBNo { get; set; }

        public decimal? FN_ERPUseNum { get; set; }

        public DateTime? FD_ERPRDate { get; set; }

        [StringLength(50)]
        public string FC_ERPReOrder { get; set; }

        [StringLength(50)]
        public string FC_MatConType { get; set; }

        [StringLength(50)]
        public string FC_ERPGFlag { get; set; }

        [StringLength(50)]
        public string FC_ERPMGNo { get; set; }

        [StringLength(50)]
        public string FC_ERPSZFlag { get; set; }

        [StringLength(50)]
        public string FC_ERPSFlag { get; set; }

        public virtual TB_Prd_PO TB_Prd_PO { get; set; }
    }
}
