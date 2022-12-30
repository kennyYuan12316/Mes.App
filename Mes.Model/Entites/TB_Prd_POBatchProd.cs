namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_POBatchProd
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Prd_POBatchProd()
        {
            TB_Prd_ProdTran = new HashSet<TB_Prd_ProdTran>();
        }

        [Key]
        [StringLength(50)]
        public string FC_ProdID { get; set; }

        [StringLength(50)]
        public string FC_BatchNo { get; set; }

        [StringLength(50)]
        public string FC_PONo { get; set; }

        [StringLength(50)]
        public string FC_CurrPS { get; set; }

        [StringLength(50)]
        public string FC_CurrPSCode { get; set; }

        [StringLength(20)]
        public string FC_ProdType { get; set; }

        [StringLength(250)]
        public string FC_ProdCode { get; set; }

        [StringLength(20)]
        public string FC_ProdFlag { get; set; }

        [StringLength(50)]
        public string FC_PID { get; set; }

        [StringLength(50)]
        public string FC_NGPSID { get; set; }

        [StringLength(50)]
        public string FC_NGPSCode { get; set; }

        [StringLength(20)]
        public string FC_ProdType2 { get; set; }

        [StringLength(250)]
        public string FC_ProdCode2 { get; set; }

        [StringLength(20)]
        public string FC_ProdType3 { get; set; }

        [StringLength(250)]
        public string FC_ProdCode3 { get; set; }

        [StringLength(300)]
        public string FC_Remarks { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_CUserID { get; set; }

        public DateTime FD_CDate { get; set; }

        [StringLength(50)]
        public string FC_UUserID { get; set; }

        public DateTime? FD_UDate { get; set; }

        [StringLength(50)]
        public string FC_MBoxID { get; set; }

        [StringLength(50)]
        public string FC_CodeNo { get; set; }

        [StringLength(50)]
        public string FC_NGGroup { get; set; }

        public virtual TB_Prd_POBatch TB_Prd_POBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Prd_ProdTran> TB_Prd_ProdTran { get; set; }
    }
}
