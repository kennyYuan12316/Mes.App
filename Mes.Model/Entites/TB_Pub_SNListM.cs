namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Pub_SNListM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Pub_SNListM()
        {
            TB_Pub_SNListD = new HashSet<TB_Pub_SNListD>();
            TB_Pub_SNRec = new HashSet<TB_Pub_SNRec>();
            TB_Pub_SNUseRec = new HashSet<TB_Pub_SNUseRec>();
        }

        [Key]
        [StringLength(50)]
        public string FC_SNID { get; set; }

        [StringLength(100)]
        public string FC_SNName { get; set; }

        [StringLength(20)]
        public string FC_SNType { get; set; }

        [StringLength(1000)]
        public string FC_SQL { get; set; }

        [StringLength(20)]
        public string FC_Enable { get; set; }

        [StringLength(200)]
        public string FC_Bak { get; set; }

        [StringLength(20)]
        public string FC_RowFlag { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_CUserID { get; set; }

        public DateTime FD_CDate { get; set; }

        [StringLength(50)]
        public string FC_UUserID { get; set; }

        public DateTime? FD_UDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Pub_SNListD> TB_Pub_SNListD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Pub_SNRec> TB_Pub_SNRec { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Pub_SNUseRec> TB_Pub_SNUseRec { get; set; }
    }
}
