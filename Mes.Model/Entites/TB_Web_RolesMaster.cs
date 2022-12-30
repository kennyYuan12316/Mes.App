namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Web_RolesMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Web_RolesMaster()
        {
            TB_Web_RolesDetail = new HashSet<TB_Web_RolesDetail>();
            TB_Web_UserRoles = new HashSet<TB_Web_UserRoles>();
        }

        [Key]
        [StringLength(50)]
        public string FC_RoleID { get; set; }

        [Required]
        [StringLength(20)]
        public string FC_RoleName { get; set; }

        [StringLength(200)]
        public string FC_Bak { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Web_RolesDetail> TB_Web_RolesDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Web_UserRoles> TB_Web_UserRoles { get; set; }
    }
}
