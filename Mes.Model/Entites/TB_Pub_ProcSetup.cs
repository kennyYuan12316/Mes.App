namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Pub_ProcSetup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Pub_ProcSetup()
        {
            TB_Pub_ProcSPs = new HashSet<TB_Pub_ProcSPs>();
            TB_Pub_PSWK = new HashSet<TB_Pub_PSWK>();
        }

        [Key]
        [StringLength(50)]
        public string FC_PSNo { get; set; }

        [StringLength(50)]
        public string FC_ClassNO { get; set; }

        [StringLength(50)]
        public string FC_Code { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_Factory { get; set; }

        [Required]
        [StringLength(200)]
        public string FC_Name { get; set; }

        [StringLength(20)]
        public string FC_ProcType { get; set; }

        [StringLength(50)]
        public string FC_DefWKNo { get; set; }

        [StringLength(20)]
        public string FC_Type { get; set; }

        public bool? FB_Enabled { get; set; }

        [StringLength(50)]
        public string FC_ERPNo { get; set; }

        [StringLength(200)]
        public string FC_ERPName { get; set; }

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

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] FD_Ver { get; set; }

        public bool? FB_HasKey { get; set; }

        public bool? FB_HasCheck { get; set; }

        public bool? FB_HavMac { get; set; }

        public bool? FB_HavYield { get; set; }

        public bool? FB_HasTran { get; set; }

        public int? FN_Display { get; set; }

        [StringLength(20)]
        public string FC_PWType { get; set; }

        [StringLength(20)]
        public string FC_TranType { get; set; }

        [StringLength(20)]
        public string FC_AutoType { get; set; }

        public virtual TB_Pub_ProcClass TB_Pub_ProcClass { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Pub_ProcSPs> TB_Pub_ProcSPs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Pub_PSWK> TB_Pub_PSWK { get; set; }
    }
}
