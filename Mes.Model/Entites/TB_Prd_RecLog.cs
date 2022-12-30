namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_RecLog
    {
        [Key]
        [StringLength(50)]
        public string FC_ERPPO { get; set; }

        [StringLength(20)]
        public string FC_Flag { get; set; }

        public DateTime? FD_Date { get; set; }

        [StringLength(50)]
        public string FC_SendID { get; set; }

        [Column(TypeName = "text")]
        public string FC_Err { get; set; }
    }
}
