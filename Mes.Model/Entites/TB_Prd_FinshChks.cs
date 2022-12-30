namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_FinshChks
    {
        [Key]
        [StringLength(50)]
        public string FC_FCNo { get; set; }

        [StringLength(50)]
        public string FC_PONo { get; set; }

        [StringLength(50)]
        public string FC_FCCode { get; set; }

        [StringLength(200)]
        public string FC_FCName { get; set; }

        [StringLength(50)]
        public string FC_ERPCode { get; set; }

        [StringLength(200)]
        public string FC_ERPName { get; set; }

        [StringLength(300)]
        public string FC_Remarks { get; set; }

        public virtual TB_Prd_PO TB_Prd_PO { get; set; }
    }
}
