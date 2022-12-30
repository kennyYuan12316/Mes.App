namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_BreakPackLog
    {
        [Key]
        public int FN_ID { get; set; }

        [StringLength(150)]
        public string FC_PackNo { get; set; }

        [StringLength(150)]
        public string FC_SN { get; set; }

        public DateTime? FD_CDate { get; set; }

        [StringLength(50)]
        public string FC_CUser { get; set; }
    }
}
