namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_QC_OQCCheck
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_QC_OQCCheck()
        {
            TB_QC_OQCCheckNG = new HashSet<TB_QC_OQCCheckNG>();
        }

        [Key]
        [StringLength(50)]
        public string FC_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FD_Date { get; set; }

        [StringLength(50)]
        public string FC_WorkCenter { get; set; }

        public int? FN_BatchNum { get; set; }

        public int? FN_BatchNGNum { get; set; }

        public int? FN_Num { get; set; }

        public int? FN_NGNum { get; set; }

        public int? FN_CheckNum { get; set; }

        [StringLength(300)]
        public string FC_Remarks { get; set; }

        [StringLength(50)]
        public string FC_Factory { get; set; }

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

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] FD_Ver { get; set; }

        [StringLength(50)]
        public string FC_SendMan { get; set; }

        [StringLength(150)]
        public string FC_SendShap { get; set; }

        [StringLength(20)]
        public string FC_CheckType { get; set; }

        [StringLength(100)]
        public string FC_BoxNo { get; set; }

        [StringLength(100)]
        public string FC_ChkNo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_QC_OQCCheckNG> TB_QC_OQCCheckNG { get; set; }
    }
}
