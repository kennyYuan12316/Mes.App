namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_POPars
    {
        [Key]
        [StringLength(50)]
        public string FC_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_PONo { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_PoParNo { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_Factory { get; set; }

        [StringLength(20)]
        public string FC_ParValue { get; set; }

        [StringLength(300)]
        public string FC_Remarks { get; set; }

        public virtual TB_Prd_PO TB_Prd_PO { get; set; }

        public virtual TB_Pub_POPars TB_Pub_POPars { get; set; }
    }
}
