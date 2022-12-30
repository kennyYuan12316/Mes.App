namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_War_StoreExcM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_War_StoreExcM()
        {
            TB_War_StoreExcD = new HashSet<TB_War_StoreExcD>();
        }

        [Key]
        [StringLength(50)]
        public string FC_ExNo { get; set; }

        [StringLength(50)]
        public string FC_Factory { get; set; }

        [StringLength(50)]
        public string FC_OutWarNo { get; set; }

        [StringLength(50)]
        public string FC_InWarNo { get; set; }

        public decimal? FN_Nums { get; set; }

        [StringLength(50)]
        public string FC_SubMan { get; set; }

        public DateTime? FD_SubDate { get; set; }

        [StringLength(50)]
        public string FC_Flag { get; set; }

        [StringLength(300)]
        public string FC_Remarks { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_RowFlag { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_CMan { get; set; }

        public DateTime FD_CDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_War_StoreExcD> TB_War_StoreExcD { get; set; }
    }
}
