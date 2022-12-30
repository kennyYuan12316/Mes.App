namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Pck_PrtSeqD
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string FC_FixChar { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string FC_PartID { get; set; }

        public decimal? FN_CurrNum { get; set; }

        public virtual TB_Pck_PrtSeqM TB_Pck_PrtSeqM { get; set; }
    }
}
