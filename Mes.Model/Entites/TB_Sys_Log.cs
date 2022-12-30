namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Sys_Log
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal FN_ID { get; set; }

        public int FN_LogType { get; set; }

        [Required]
        [StringLength(100)]
        public string FC_ModuleID { get; set; }

        [StringLength(100)]
        public string FC_FuncCode { get; set; }

        [StringLength(1000)]
        public string FC_OprNote { get; set; }

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
