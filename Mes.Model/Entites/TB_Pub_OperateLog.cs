namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Pub_OperateLog
    {
        [Key]
        public long FN_LogID { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_Module { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_Func { get; set; }

        [Required]
        [StringLength(20)]
        public string FC_Type { get; set; }

        [StringLength(200)]
        public string FC_Before { get; set; }

        [StringLength(200)]
        public string FC_After { get; set; }

        [StringLength(500)]
        public string FC_Desc { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_UserID { get; set; }

        public DateTime FD_Date { get; set; }

        [StringLength(50)]
        public string FC_IP { get; set; }

        [StringLength(100)]
        public string FC_PC { get; set; }
    }
}
