namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Pub_POPars
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Pub_POPars()
        {
            TB_Prd_POPars = new HashSet<TB_Prd_POPars>();
        }

        [Key]
        [StringLength(50)]
        public string FC_PoParNo { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_Factory { get; set; }

        [Required]
        [StringLength(200)]
        public string FC_Name { get; set; }

        [StringLength(50)]
        public string FC_Type { get; set; }

        [StringLength(20)]
        public string FC_DictNo { get; set; }

        [StringLength(200)]
        public string FC_Ext1 { get; set; }

        [StringLength(200)]
        public string FC_Ext2 { get; set; }

        [StringLength(200)]
        public string FC_Ext3 { get; set; }

        public bool FB_Enabled { get; set; }

        [StringLength(300)]
        public string FC_Remarks { get; set; }

        [Required]
        [StringLength(20)]
        public string FC_RowFlag { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_CUserID { get; set; }

        public DateTime FD_CDate { get; set; }

        [StringLength(50)]
        public string FC_UUserID { get; set; }

        public DateTime? FD_UDate { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] FD_Ver { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Prd_POPars> TB_Prd_POPars { get; set; }
    }
}
