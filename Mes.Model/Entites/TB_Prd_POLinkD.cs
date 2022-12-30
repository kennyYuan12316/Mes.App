namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_POLinkD
    {
        [Key]
        [StringLength(50)]
        public string FC_LinkDNo { get; set; }

        [StringLength(50)]
        public string FC_LinkNo { get; set; }

        public int FN_Order { get; set; }

        [StringLength(50)]
        public string FC_PONo { get; set; }

        public decimal? FN_PerOne { get; set; }

        public int? FN_MaxOrder { get; set; }

        [StringLength(50)]
        public string FC_EndPONo { get; set; }

        [StringLength(50)]
        public string FC_FPONo { get; set; }

        public virtual TB_Prd_POLinkM TB_Prd_POLinkM { get; set; }
    }
}
