namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_War_ChkLab
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_War_ChkLab()
        {
            TB_War_PackLab = new HashSet<TB_War_PackLab>();
        }

        [Key]
        [StringLength(50)]
        public string FC_ChkID { get; set; }

        [StringLength(20)]
        public string FC_PackType { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_Factory { get; set; }

        [StringLength(50)]
        public string FC_PNo { get; set; }

        [StringLength(300)]
        public string FC_Shape { get; set; }

        public decimal? FC_PackNums { get; set; }

        public int FN_Order { get; set; }

        public decimal? FN_PackNum { get; set; }

        public decimal? FN_UpPackNum { get; set; }

        public decimal? FN_PassNum { get; set; }

        public decimal? FN_NGNum { get; set; }

        [StringLength(50)]
        public string FC_Unit { get; set; }

        [StringLength(20)]
        public string FC_Flag { get; set; }

        [StringLength(50)]
        public string FC_FMan { get; set; }

        public DateTime? FD_FDate { get; set; }

        [StringLength(300)]
        public string FC_Remarks { get; set; }

        [StringLength(20)]
        public string FC_RowFlag { get; set; }

        [StringLength(50)]
        public string FC_InMan { get; set; }

        [StringLength(50)]
        public string FC_CUserID { get; set; }

        public DateTime? FD_CDate { get; set; }

        [StringLength(50)]
        public string FC_UUserID { get; set; }

        public DateTime? FD_UDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_War_PackLab> TB_War_PackLab { get; set; }
    }
}
