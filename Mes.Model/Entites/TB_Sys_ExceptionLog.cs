namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Sys_ExceptionLog
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal FN_ID { get; set; }

        public int? FN_Level { get; set; }

        [StringLength(500)]
        public string FC_Sender { get; set; }

        public string FC_Message { get; set; }

        public string FC_Call { get; set; }

        public string FC_Source { get; set; }

        [StringLength(50)]
        public string FC_IP { get; set; }

        [StringLength(50)]
        public string FC_UserID { get; set; }

        [StringLength(100)]
        public string FC_UserName { get; set; }

        public DateTime? FD_OprDate { get; set; }

        [StringLength(20)]
        public string FC_ClientType { get; set; }
    }
}
