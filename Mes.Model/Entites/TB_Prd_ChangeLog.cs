namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_ChangeLog
    {
        [Key]
        [StringLength(50)]
        public string FC_ChgID { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_ERPPO { get; set; }

        public DateTime? FD_Date { get; set; }

        [StringLength(20)]
        public string FC_ChgFlag { get; set; }

        [StringLength(20)]
        public string FC_ProcFlag { get; set; }

        [StringLength(3000)]
        public string FC_Remarks { get; set; }

        [StringLength(50)]
        public string FC_SendID { get; set; }
    }
}
