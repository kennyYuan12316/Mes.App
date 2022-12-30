namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Pck_PrtRec
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Pck_PrtRec()
        {
            TB_Prd_PrtBatchList = new HashSet<TB_Prd_PrtBatchList>();
            TB_Prd_PoPackList = new HashSet<TB_Prd_PoPackList>();
        }

        [Key]
        [StringLength(50)]
        public string FC_PrtID { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_Factory { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_PONo { get; set; }

        [StringLength(50)]
        public string FC_PNo { get; set; }

        [StringLength(50)]
        public string FC_PVer { get; set; }

        [StringLength(20)]
        public string FC_Flag { get; set; }

        [StringLength(300)]
        public string FC_PExt1 { get; set; }

        [StringLength(300)]
        public string FC_PExt2 { get; set; }

        [StringLength(300)]
        public string FC_PExt3 { get; set; }

        [StringLength(300)]
        public string FC_PExt4 { get; set; }

        [StringLength(300)]
        public string FC_PExt5 { get; set; }

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

        public decimal? FN_Nums { get; set; }

        [StringLength(50)]
        public string FC_FMan { get; set; }

        public DateTime? FD_FDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Prd_PrtBatchList> TB_Prd_PrtBatchList { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Prd_PoPackList> TB_Prd_PoPackList { get; set; }
    }
}
