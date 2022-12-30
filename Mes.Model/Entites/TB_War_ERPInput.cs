namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_War_ERPInput
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_War_ERPInput()
        {
            TB_War_ERPInputD = new HashSet<TB_War_ERPInputD>();
            TB_War_ERPInputLab = new HashSet<TB_War_ERPInputLab>();
            TB_War_ERPInputBG = new HashSet<TB_War_ERPInputBG>();
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

        [StringLength(50)]
        public string FC_InMan { get; set; }

        [StringLength(20)]
        public string FC_RLFlag { get; set; }

        [StringLength(20)]
        public string FC_ClientType { get; set; }

        public decimal? FN_BoxNums { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_War_ERPInputD> TB_War_ERPInputD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_War_ERPInputLab> TB_War_ERPInputLab { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_War_ERPInputBG> TB_War_ERPInputBG { get; set; }
    }
}
