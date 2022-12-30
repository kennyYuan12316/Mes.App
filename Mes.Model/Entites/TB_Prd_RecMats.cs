namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_RecMats
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Prd_RecMats()
        {
            TB_Prd_BatchUseMatD = new HashSet<TB_Prd_BatchUseMatD>();
        }

        [Key]
        [StringLength(50)]
        public string FC_POMatNo { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_Factory { get; set; }

        [StringLength(50)]
        public string FC_PONo { get; set; }

        [StringLength(50)]
        public string FC_WarNo { get; set; }

        public decimal? FN_PerOne { get; set; }

        [StringLength(50)]
        public string FC_MatNo { get; set; }

        [StringLength(200)]
        public string FC_MatName { get; set; }

        [StringLength(200)]
        public string FC_Shape { get; set; }

        public decimal? FN_Nums { get; set; }

        public decimal? FN_UseNums { get; set; }

        [StringLength(50)]
        public string FC_SetupNo { get; set; }

        [StringLength(50)]
        public string FC_Unit { get; set; }

        public decimal? FN_ERPRecNum { get; set; }

        public decimal? FN_ERPBackNum { get; set; }

        [StringLength(50)]
        public string FC_SuprNo { get; set; }

        [StringLength(200)]
        public string FC_SupName { get; set; }

        [StringLength(50)]
        public string FC_SoNo { get; set; }

        [StringLength(50)]
        public string FC_ErpRecNo { get; set; }

        [StringLength(50)]
        public string FC_ErpRecBNo { get; set; }

        [StringLength(50)]
        public string FC_ErpWarNo { get; set; }

        [StringLength(200)]
        public string FC_ErpWarName { get; set; }

        [StringLength(50)]
        public string FC_ErpSetupNo { get; set; }

        [StringLength(50)]
        public string FC_WarID { get; set; }

        [StringLength(50)]
        public string FC_RowItem { get; set; }

        [StringLength(50)]
        public string FC_MatTNo { get; set; }

        [StringLength(50)]
        public string FC_MatGNo { get; set; }

        [StringLength(50)]
        public string FC_ERPMVType { get; set; }

        [StringLength(50)]
        public string FC_ERPUseNo { get; set; }

        [StringLength(50)]
        public string FC_ERPYear { get; set; }

        [StringLength(500)]
        public string FC_MatGNote { get; set; }

        [StringLength(500)]
        public string FC_MatTNote { get; set; }

        [StringLength(50)]
        public string FC_ERPSDate { get; set; }

        [StringLength(50)]
        public string FC_ERPRecDate { get; set; }

        [StringLength(8)]
        public string FC_MatCheck { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Prd_BatchUseMatD> TB_Prd_BatchUseMatD { get; set; }

        public virtual TB_Prd_PO TB_Prd_PO { get; set; }

        public virtual TB_Pub_Warehouse TB_Pub_Warehouse { get; set; }
    }
}
