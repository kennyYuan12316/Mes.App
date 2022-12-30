namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_POBatch_20220607
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string FC_BatchNo { get; set; }

        [StringLength(50)]
        public string FC_PONo { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FN_Order { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string FC_BatchCode { get; set; }

        public decimal? FN_SNums { get; set; }

        [Key]
        [Column(Order = 3)]
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

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string FC_BFlag { get; set; }

        public DateTime? FD_SDate { get; set; }

        public DateTime? FD_FDate { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string FC_Factory { get; set; }

        [StringLength(20)]
        public string FC_HisFlag { get; set; }

        [StringLength(300)]
        public string FC_Remarks { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(20)]
        public string FC_RowFlag { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string FC_CUserID { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime FD_CDate { get; set; }

        [StringLength(50)]
        public string FC_UUserID { get; set; }

        public DateTime? FD_UDate { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] FD_Ver { get; set; }

        [Key]
        [Column(Order = 9)]
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

        [Key]
        [Column(Order = 10)]
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
    }
}
