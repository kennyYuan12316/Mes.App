namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_POStart
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Prd_POStart()
        {
            TB_Prd_POBatch = new HashSet<TB_Prd_POBatch>();
        }

        [Key]
        [StringLength(50)]
        public string FC_ID { get; set; }

        public decimal? FN_StartNums { get; set; }

        [StringLength(50)]
        public string FC_PONo { get; set; }

        public int? FN_Order { get; set; }

        public decimal? FN_PCNums { get; set; }

        public int? FN_PBatchNums { get; set; }

        public DateTime? FD_PDate { get; set; }

        [StringLength(50)]
        public string FC_PMan { get; set; }

        [Required]
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

        [Required]
        [StringLength(50)]
        public string FC_Factory { get; set; }

        public virtual TB_Prd_PO TB_Prd_PO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Prd_POBatch> TB_Prd_POBatch { get; set; }
    }
}
