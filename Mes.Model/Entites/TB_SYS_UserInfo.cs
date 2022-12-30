namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_SYS_UserInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_SYS_UserInfo()
        {
            TB_Web_UserRoles = new HashSet<TB_Web_UserRoles>();
            TB_Web_ModuleDetail = new HashSet<TB_Web_ModuleDetail>();
        }

        [Key]
        [StringLength(20)]
        public string FC_UserID { get; set; }

        [StringLength(50)]
        public string FC_HRID { get; set; }

        [StringLength(100)]
        public string FC_Password { get; set; }

        [StringLength(20)]
        public string FC_PasswordType { get; set; }

        public int? FN_Lock { get; set; }

        public int? FN_Flag { get; set; }

        public DateTime? FD_EndDate { get; set; }

        public DateTime? FD_LastActivityDate { get; set; }

        public int? FN_RowFlag { get; set; }

        [StringLength(100)]
        public string FC_CardNo { get; set; }

        [Required]
        [StringLength(20)]
        public string FC_CUserID { get; set; }

        public DateTime FD_CDate { get; set; }

        [StringLength(20)]
        public string FC_UUserID { get; set; }

        public DateTime? FD_UDate { get; set; }

        [StringLength(500)]
        public string FC_AllowData { get; set; }

        [StringLength(500)]
        public string FC_AllowData2 { get; set; }

        [StringLength(500)]
        public string FC_AllowData3 { get; set; }

        [StringLength(500)]
        public string FC_AllowData4 { get; set; }

        [StringLength(500)]
        public string FC_AllowData5 { get; set; }

        [StringLength(200)]
        public string FC_Ext1 { get; set; }

        [StringLength(200)]
        public string FC_Ext2 { get; set; }

        [StringLength(200)]
        public string FC_Ext3 { get; set; }

        public DateTime? FD_LockEnd { get; set; }

        public int? FN_PasErrCount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Web_UserRoles> TB_Web_UserRoles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Web_ModuleDetail> TB_Web_ModuleDetail { get; set; }
    }
}
