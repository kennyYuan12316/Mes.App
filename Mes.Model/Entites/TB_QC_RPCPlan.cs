namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_QC_RPCPlan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_QC_RPCPlan()
        {
            TB_QC_SPCPlanD = new HashSet<TB_QC_SPCPlanD>();
            TB_QC_SPCRec = new HashSet<TB_QC_SPCRec>();
        }

        [Key]
        [StringLength(50)]
        public string FC_PId { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_PONo { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_PNo { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_Factory { get; set; }

        public int FN_Num { get; set; }

        public int FN_PNum { get; set; }

        [StringLength(20)]
        public string FC_Flag { get; set; }

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

        [StringLength(200)]
        public string FC_PName { get; set; }

        [StringLength(200)]
        public string FC_Tool { get; set; }

        [StringLength(200)]
        public string FC_Mac { get; set; }

        [StringLength(100)]
        public string FC_PSName { get; set; }

        public int? FN_CurrNum { get; set; }

        [StringLength(300)]
        public string FC_Shape { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_QC_SPCPlanD> TB_QC_SPCPlanD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_QC_SPCRec> TB_QC_SPCRec { get; set; }
    }
}
