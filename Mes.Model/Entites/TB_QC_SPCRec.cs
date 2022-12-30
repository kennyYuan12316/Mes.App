namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_QC_SPCRec
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_QC_SPCRec()
        {
            TB_QC_SPCRecD = new HashSet<TB_QC_SPCRecD>();
        }

        [Key]
        [StringLength(50)]
        public string FC_PDId { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_PId { get; set; }

        public int FN_Order { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_ChkID { get; set; }

        public DateTime FD_Time { get; set; }

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

        public virtual TB_QC_RPCPlan TB_QC_RPCPlan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_QC_SPCRecD> TB_QC_SPCRecD { get; set; }
    }
}
