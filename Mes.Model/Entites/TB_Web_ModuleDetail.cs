namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Web_ModuleDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Web_ModuleDetail()
        {
            TB_Web_RolesDetail = new HashSet<TB_Web_RolesDetail>();
            TB_SYS_UserInfo = new HashSet<TB_SYS_UserInfo>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string FC_ModuleID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string FC_FuncCode { get; set; }

        [StringLength(100)]
        public string FC_Name { get; set; }

        public int? FN_FuncType { get; set; }

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

        [StringLength(200)]
        public string FC_Ext1 { get; set; }

        [StringLength(200)]
        public string FC_Ext2 { get; set; }

        [StringLength(200)]
        public string FC_Ext3 { get; set; }

        [StringLength(200)]
        public string FC_Ext4 { get; set; }

        [StringLength(200)]
        public string FC_Ext5 { get; set; }

        public virtual TB_Web_ModuleMaster TB_Web_ModuleMaster { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Web_RolesDetail> TB_Web_RolesDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_SYS_UserInfo> TB_SYS_UserInfo { get; set; }
    }
}
