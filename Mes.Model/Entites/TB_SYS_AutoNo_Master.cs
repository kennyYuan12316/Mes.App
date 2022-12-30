namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_SYS_AutoNo_Master
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_SYS_AutoNo_Master()
        {
            TB_SYS_AutoNo_Detail = new HashSet<TB_SYS_AutoNo_Detail>();
            TB_SYS_AutoNo_Rec = new HashSet<TB_SYS_AutoNo_Rec>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string FC_TableName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string FC_ColumnName { get; set; }

        public int? FN_AutoType { get; set; }

        public bool? FN_Enable { get; set; }

        [StringLength(200)]
        public string FC_Bak { get; set; }

        public int? FN_RowFlag { get; set; }

        [Required]
        [StringLength(20)]
        public string FC_CUserID { get; set; }

        public DateTime FD_CDate { get; set; }

        [StringLength(20)]
        public string FC_UUserID { get; set; }

        public DateTime? FD_UDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_SYS_AutoNo_Detail> TB_SYS_AutoNo_Detail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_SYS_AutoNo_Rec> TB_SYS_AutoNo_Rec { get; set; }
    }
}
