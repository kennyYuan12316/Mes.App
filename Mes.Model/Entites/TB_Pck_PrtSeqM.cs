namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Pck_PrtSeqM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Pck_PrtSeqM()
        {
            TB_Pck_PrtSeqD = new HashSet<TB_Pck_PrtSeqD>();
            TB_Pck_PrtSeqRec = new HashSet<TB_Pck_PrtSeqRec>();
        }

        [Key]
        [StringLength(50)]
        public string FC_PartID { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_CUserID { get; set; }

        public DateTime FD_CDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Pck_PrtSeqD> TB_Pck_PrtSeqD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Pck_PrtSeqRec> TB_Pck_PrtSeqRec { get; set; }
    }
}
