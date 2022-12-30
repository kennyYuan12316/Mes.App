namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Web_UserRoles
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string FC_UserID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string FC_RoleID { get; set; }

        public int? FN_RowFlag { get; set; }

        [Required]
        [StringLength(20)]
        public string FC_CUserID { get; set; }

        public DateTime FD_CDate { get; set; }

        [StringLength(20)]
        public string FC_UUserID { get; set; }

        public DateTime? FD_UDate { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] FD_Version { get; set; }

        public virtual TB_SYS_UserInfo TB_SYS_UserInfo { get; set; }

        public virtual TB_Web_RolesMaster TB_Web_RolesMaster { get; set; }
    }
}
