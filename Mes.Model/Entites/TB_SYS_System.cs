namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_SYS_System
    {
        [Key]
        [StringLength(50)]
        public string SystemID { get; set; }

        [StringLength(20)]
        public string FC_ClientType { get; set; }

        [StringLength(200)]
        public string SystemName { get; set; }

        [StringLength(200)]
        public string UpdateUrl { get; set; }

        [StringLength(50)]
        public string CurrVer { get; set; }

        [StringLength(100)]
        public string FC_LogUser { get; set; }

        [StringLength(100)]
        public string FC_LogUserPwd { get; set; }

        public int? FN_RowFlag { get; set; }

        [Required]
        [StringLength(20)]
        public string FC_CUserID { get; set; }

        public DateTime FD_CDate { get; set; }

        [StringLength(20)]
        public string FC_UUserID { get; set; }

        public DateTime? FD_UDate { get; set; }
    }
}
