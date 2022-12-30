namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Web_ModuleMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Web_ModuleMaster()
        {
            TB_Web_ModuleDetail = new HashSet<TB_Web_ModuleDetail>();
        }

        [Key]
        [StringLength(100)]
        public string FC_ModuleID { get; set; }

        [Required]
        [StringLength(100)]
        public string FC_Name { get; set; }

        [StringLength(100)]
        public string FC_ImageUrl { get; set; }

        [StringLength(100)]
        public string FC_URL { get; set; }

        [StringLength(100)]
        public string FC_Qtips { get; set; }

        public int? FN_SortNum { get; set; }

        [StringLength(100)]
        public string FC_ParentID { get; set; }

        public bool? FB_Enable { get; set; }

        public bool? FB_Visible { get; set; }

        public bool? FB_Iframe { get; set; }

        public int? FN_NavType { get; set; }

        public bool? FB_ACEnable { get; set; }

        [StringLength(100)]
        public string FC_ACType { get; set; }

        [StringLength(600)]
        public string FC_Dicts { get; set; }

        [StringLength(100)]
        public string FC_ModuleType { get; set; }

        public bool? FB_AutoData { get; set; }

        [StringLength(200)]
        public string FC_Description { get; set; }

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

        [StringLength(20)]
        public string FC_ClientType { get; set; }

        [Column(TypeName = "image")]
        public byte[] FI_Image { get; set; }

        [StringLength(100)]
        public string FC_Command { get; set; }

        public int? FN_ImageOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Web_ModuleDetail> TB_Web_ModuleDetail { get; set; }
    }
}
