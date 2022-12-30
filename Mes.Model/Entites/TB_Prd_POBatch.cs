namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_POBatch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Prd_POBatch()
        {
            TB_Prd_POBatchProd = new HashSet<TB_Prd_POBatchProd>();
            TB_Prd_TranInfo = new HashSet<TB_Prd_TranInfo>();
        }

        [Key]
        [StringLength(50)]
        public string FC_BatchNo { get; set; }

        [StringLength(50)]
        public string FC_PONo { get; set; }

        public int FN_Order { get; set; }

        [Required]
        [StringLength(100)]
        public string FC_BatchCode { get; set; }

        public decimal? FN_SNums { get; set; }

        public decimal FN_PONums { get; set; }

        public decimal? FN_FNums { get; set; }

        [StringLength(50)]
        public string FC_Unit { get; set; }

        [StringLength(50)]
        public string FC_CurrPS { get; set; }

        [StringLength(50)]
        public string FC_CurrPSCode { get; set; }

        [StringLength(100)]
        public string FC_ERPBCode { get; set; }

        [Required]
        [StringLength(20)]
        public string FC_BFlag { get; set; }

        public DateTime? FD_SDate { get; set; }

        public DateTime? FD_FDate { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_Factory { get; set; }

        [StringLength(20)]
        public string FC_HisFlag { get; set; }

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
        [StringLength(20)]
        public string FC_BCType { get; set; }

        [StringLength(50)]
        public string FC_TCID { get; set; }

        [StringLength(50)]
        public string FC_BackNo { get; set; }

        [StringLength(50)]
        public string FC_PSCodeID { get; set; }

        [StringLength(50)]
        public string FC_PSCode { get; set; }

        public decimal? FN_BackNums { get; set; }

        [StringLength(50)]
        public string FC_CurrBPS { get; set; }

        [StringLength(50)]
        public string FC_CurrBPSCode { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal FN_ERPBNo { get; set; }

        [StringLength(20)]
        public string FC_MatFlag { get; set; }

        [StringLength(20)]
        public string FC_SplitFlag { get; set; }

        [StringLength(50)]
        public string FC_OldBatchNo { get; set; }

        public decimal? FN_SplitNums { get; set; }

        [StringLength(50)]
        public string FC_SplitPS { get; set; }

        [StringLength(50)]
        public string FC_SplitPSCode { get; set; }

        public int? FN_SplitNum { get; set; }

        [StringLength(20)]
        public string FC_BPrtFlag { get; set; }

        public decimal? FN_PrtNums { get; set; }

        [StringLength(50)]
        public string FC_BatchMat { get; set; }

        public virtual TB_Prd_PO TB_Prd_PO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Prd_POBatchProd> TB_Prd_POBatchProd { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Prd_TranInfo> TB_Prd_TranInfo { get; set; }

        public virtual TB_Prd_POStart TB_Prd_POStart { get; set; }

        public virtual TB_Prd_POBatch TB_Prd_POBatch1 { get; set; }

        public virtual TB_Prd_POBatch TB_Prd_POBatch2 { get; set; }
    }
}
