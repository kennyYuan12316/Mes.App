namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_War_NGERPInput
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_War_NGERPInput()
        {
            TB_War_NGERPInputD = new HashSet<TB_War_NGERPInputD>();
            TB_War_NGERPInputBG = new HashSet<TB_War_NGERPInputBG>();
        }

        [Key]
        [StringLength(50)]
        public string FC_INNo { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_Factory { get; set; }

        [StringLength(50)]
        public string FC_MesWarNo { get; set; }

        [StringLength(50)]
        public string FC_ERPWarNo { get; set; }

        [StringLength(50)]
        public string FC_SubMan { get; set; }

        public DateTime? FD_SubDate { get; set; }

        [StringLength(20)]
        public string FC_Flag { get; set; }

        [StringLength(20)]
        public string FC_ERPUpdFlag { get; set; }

        [StringLength(300)]
        public string FC_Remarks { get; set; }

        [Required]
        [StringLength(20)]
        public string FC_RowFlag { get; set; }

        [StringLength(50)]
        public string FC_InMan { get; set; }

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
        public virtual ICollection<TB_War_NGERPInputD> TB_War_NGERPInputD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_War_NGERPInputBG> TB_War_NGERPInputBG { get; set; }
    }
}
