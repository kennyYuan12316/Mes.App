namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_SYS_Config
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_SYS_Config()
        {
            TB_SYS_ConfigDetail = new HashSet<TB_SYS_ConfigDetail>();
        }

        [Key]
        [StringLength(100)]
        public string FC_CoinfigID { get; set; }

        public int? FC_Type { get; set; }

        [StringLength(200)]
        public string FC_Bak { get; set; }

        public int? FN_RunGet { get; set; }

        public int? FN_RowFlag { get; set; }

        [Required]
        [StringLength(20)]
        public string FC_CUserID { get; set; }

        public DateTime FD_CDate { get; set; }

        [StringLength(20)]
        public string FC_UUserID { get; set; }

        public DateTime? FD_UDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_SYS_ConfigDetail> TB_SYS_ConfigDetail { get; set; }
    }
}
