namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_PO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Prd_PO()
        {
            TB_Prd_AccDetail = new HashSet<TB_Prd_AccDetail>();
            TB_Prd_FinshChks = new HashSet<TB_Prd_FinshChks>();
            TB_Prd_PoPackInfo = new HashSet<TB_Prd_PoPackInfo>();
            TB_Prd_POStart = new HashSet<TB_Prd_POStart>();
            TB_Prd_POMats = new HashSet<TB_Prd_POMats>();
            TB_Prd_POPars = new HashSet<TB_Prd_POPars>();
            TB_Prd_POSetup = new HashSet<TB_Prd_POSetup>();
            TB_Prd_RecMats = new HashSet<TB_Prd_RecMats>();
            TB_Prd_POBatch = new HashSet<TB_Prd_POBatch>();
        }

        [Key]
        [StringLength(50)]
        public string FC_PONo { get; set; }

        [StringLength(50)]
        public string FC_LinkNo { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_Factory { get; set; }

        [StringLength(50)]
        public string FC_PNo { get; set; }

        [StringLength(50)]
        public string FC_PVer { get; set; }

        [StringLength(300)]
        public string FC_PName { get; set; }

        [StringLength(300)]
        public string FC_Shape { get; set; }

        [StringLength(20)]
        public string FC_CreateType { get; set; }

        [StringLength(20)]
        public string FC_POType { get; set; }

        public decimal? FN_PONums { get; set; }

        [StringLength(50)]
        public string FC_Unit { get; set; }

        public DateTime? FD_RDate { get; set; }

        public DateTime? FD_FDate { get; set; }

        public DateTime? FD_ConDate { get; set; }

        [StringLength(50)]
        public string FC_ConMan { get; set; }

        public DateTime? FD_PDate { get; set; }

        [StringLength(50)]
        public string FC_PMan { get; set; }

        public int? FN_PBatchNums { get; set; }

        public decimal? FN_FNums { get; set; }

        public decimal? FN_PBNums { get; set; }

        public decimal? FN_NGNums { get; set; }

        [StringLength(50)]
        public string FC_MESRMNo { get; set; }

        [StringLength(50)]
        public string FC_SONo { get; set; }

        [StringLength(50)]
        public string FC_ERPPO { get; set; }

        [StringLength(50)]
        public string FC_ERPWarNo { get; set; }

        [StringLength(300)]
        public string FC_ERPWarName { get; set; }

        [StringLength(50)]
        public string FC_ERPCustNo { get; set; }

        [StringLength(300)]
        public string FC_ERPCustName { get; set; }

        [StringLength(50)]
        public string FC_ERPYWDept { get; set; }

        [StringLength(300)]
        public string FC_ERPYWDeptName { get; set; }

        [StringLength(50)]
        public string FC_ERPRNo { get; set; }

        [StringLength(50)]
        public string FC_ERPRVer { get; set; }

        public DateTime? FC_ERPSData { get; set; }

        [StringLength(50)]
        public string FC_ERPPTNo { get; set; }

        [StringLength(300)]
        public string FC_ERPPTName { get; set; }

        [StringLength(50)]
        public string FC_ERPYWEmpNo { get; set; }

        [StringLength(100)]
        public string FC_ERPYWEmpName { get; set; }

        [StringLength(20)]
        public string FC_Flag { get; set; }

        [StringLength(20)]
        public string FC_HisFlag { get; set; }

        [StringLength(50)]
        public string FC_RecBatch { get; set; }

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
        public string FC_ERPFlag { get; set; }

        public decimal? FN_PCNums { get; set; }

        public decimal? FN_TCNums { get; set; }

        [StringLength(50)]
        public string FC_NGGroup { get; set; }

        [StringLength(20)]
        public string FC_FacPOType { get; set; }

        public DateTime? FD_ERPSDate { get; set; }

        public DateTime? FD_ERPCDate { get; set; }

        [StringLength(50)]
        public string FC_ERPUnitISO { get; set; }

        [StringLength(50)]
        public string FC_SalePNo { get; set; }

        [StringLength(60)]
        public string FC_SalePShape { get; set; }

        [StringLength(50)]
        public string FC_ERPSaleItem { get; set; }

        [StringLength(50)]
        public string FC_RecMan { get; set; }

        public DateTime? FD_RecDate { get; set; }

        public decimal? FN_POTCNums { get; set; }

        public decimal? FN_ERPInPer { get; set; }

        public decimal? FN_ERPChgNums { get; set; }

        [StringLength(100)]
        public string FC_ERPLG { get; set; }

        public decimal? FN_ERPLG { get; set; }

        [StringLength(50)]
        public string FC_LCDQWC { get; set; }

        public decimal? FN_AccTCNums { get; set; }

        [StringLength(100)]
        public string FC_ERPCustSo { get; set; }

        public decimal? FN_ERPSONums { get; set; }

        public DateTime? FD_ERPPSDate { get; set; }

        public DateTime? FD_ERPClose { get; set; }

        public decimal? FN_LabPrtNums { get; set; }

        [StringLength(150)]
        public string FC_CustMatNo { get; set; }

        [StringLength(150)]
        public string FC_CustMatNoDesc { get; set; }

        [StringLength(150)]
        public string FC_CustOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Prd_AccDetail> TB_Prd_AccDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Prd_FinshChks> TB_Prd_FinshChks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Prd_PoPackInfo> TB_Prd_PoPackInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Prd_POStart> TB_Prd_POStart { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Prd_POMats> TB_Prd_POMats { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Prd_POPars> TB_Prd_POPars { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Prd_POSetup> TB_Prd_POSetup { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Prd_RecMats> TB_Prd_RecMats { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Prd_POBatch> TB_Prd_POBatch { get; set; }
    }
}
