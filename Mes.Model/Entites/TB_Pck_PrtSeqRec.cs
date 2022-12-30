namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Pck_PrtSeqRec
    {
        [Key]
        [StringLength(50)]
        public string FC_UseID { get; set; }

        [StringLength(50)]
        public string FC_PartID { get; set; }

        public decimal? FN_GetNum { get; set; }

        [StringLength(50)]
        public string FC_Factory { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_CUserID { get; set; }

        public DateTime FD_CDate { get; set; }

        public virtual TB_Pck_PrtSeqM TB_Pck_PrtSeqM { get; set; }
    }
}
