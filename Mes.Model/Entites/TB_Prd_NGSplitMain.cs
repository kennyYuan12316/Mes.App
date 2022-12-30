namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_NGSplitMain
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Prd_NGSplitMain()
        {
            TB_Prd_NGSplitDetial = new HashSet<TB_Prd_NGSplitDetial>();
            TB_Prd_NGSplitOutM = new HashSet<TB_Prd_NGSplitOutM>();
        }

        [Key]
        [StringLength(50)]
        public string FC_NGSplitNo { get; set; }

        [StringLength(50)]
        public string FC_Factory { get; set; }

        [StringLength(50)]
        public string FC_PONo { get; set; }

        public decimal? FN_APPNum { get; set; }

        [StringLength(50)]
        public string FC_WarID { get; set; }

        [StringLength(20)]
        public string FC_Flag { get; set; }

        [StringLength(50)]
        public string FC_SubMan { get; set; }

        public DateTime? FD_SubDate { get; set; }

        [StringLength(50)]
        public string FC_ConMan { get; set; }

        public DateTime? FD_ConDate { get; set; }

        [StringLength(300)]
        public string FC_Remarks { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_CUserID { get; set; }

        [Required]
        [StringLength(20)]
        public string FC_RowFlag { get; set; }

        public DateTime FD_CDate { get; set; }

        [StringLength(50)]
        public string FC_UUserID { get; set; }

        public DateTime? FD_UDate { get; set; }

        [StringLength(10)]
        public string FD_APPType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Prd_NGSplitDetial> TB_Prd_NGSplitDetial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Prd_NGSplitOutM> TB_Prd_NGSplitOutM { get; set; }
    }
}
