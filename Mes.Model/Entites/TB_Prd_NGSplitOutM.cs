namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_NGSplitOutM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Prd_NGSplitOutM()
        {
            TB_Prd_NGSplitOutD = new HashSet<TB_Prd_NGSplitOutD>();
        }

        [Key]
        [StringLength(50)]
        public string FC_SplitOutNo { get; set; }

        [StringLength(50)]
        public string FC_NGSplitNo { get; set; }

        [StringLength(50)]
        public string FC_Factory { get; set; }

        [StringLength(50)]
        public string FC_PONo { get; set; }

        public decimal? FC_OutputNum { get; set; }

        [StringLength(300)]
        public string FC_Remarks { get; set; }

        [StringLength(20)]
        public string FC_Flag { get; set; }

        [StringLength(50)]
        public string FC_CUserID { get; set; }

        public DateTime? FC_CDate { get; set; }

        public virtual TB_Prd_NGSplitMain TB_Prd_NGSplitMain { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Prd_NGSplitOutD> TB_Prd_NGSplitOutD { get; set; }
    }
}
