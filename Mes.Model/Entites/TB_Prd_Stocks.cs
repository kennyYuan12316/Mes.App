namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_Stocks
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Prd_Stocks()
        {
            TB_Prd_BackPOD = new HashSet<TB_Prd_BackPOD>();
            TB_Prd_StockInfo = new HashSet<TB_Prd_StockInfo>();
            TB_War_NGERPInputD = new HashSet<TB_War_NGERPInputD>();
            TB_War_ERPInputD = new HashSet<TB_War_ERPInputD>();
        }

        [StringLength(50)]
        public string FC_WarNo { get; set; }

        [StringLength(50)]
        public string FC_TranNo { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_Factory { get; set; }

        [Required]
        [StringLength(20)]
        public string FC_WarType { get; set; }

        [StringLength(20)]
        public string FC_PType { get; set; }

        [StringLength(20)]
        public string FC_NGCodeNo { get; set; }

        [StringLength(50)]
        public string FC_PSNo { get; set; }

        public decimal? FN_CurrNums { get; set; }

        [StringLength(50)]
        public string FC_Units { get; set; }

        public decimal? FN_InNums { get; set; }

        [StringLength(50)]
        public string FC_PONo { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_BatchNo { get; set; }

        [StringLength(50)]
        public string FC_SONo { get; set; }

        [StringLength(50)]
        public string FC_ERPPO { get; set; }

        [StringLength(50)]
        public string FC_PNo { get; set; }

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
        public string FC_PSCode { get; set; }

        [Key]
        [StringLength(50)]
        public string FC_ID { get; set; }

        [StringLength(20)]
        public string FC_RetFlag { get; set; }

        [StringLength(50)]
        public string FC_NGGroup { get; set; }

        [StringLength(50)]
        public string FC_WKNo { get; set; }

        [StringLength(50)]
        public string FC_NGNo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Prd_BackPOD> TB_Prd_BackPOD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Prd_StockInfo> TB_Prd_StockInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_War_NGERPInputD> TB_War_NGERPInputD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_War_ERPInputD> TB_War_ERPInputD { get; set; }

        public virtual TB_Pub_Warehouse TB_Pub_Warehouse { get; set; }

        public virtual TB_Prd_TranInfo TB_Prd_TranInfo { get; set; }
    }
}
