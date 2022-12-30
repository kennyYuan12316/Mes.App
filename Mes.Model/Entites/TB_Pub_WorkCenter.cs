namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Pub_WorkCenter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Pub_WorkCenter()
        {
            TB_Pub_Machines = new HashSet<TB_Pub_Machines>();
            TB_Pub_PSWK = new HashSet<TB_Pub_PSWK>();
            TB_Pub_WCQCParms = new HashSet<TB_Pub_WCQCParms>();
        }

        [Key]
        [StringLength(50)]
        public string FC_WKNo { get; set; }

        [StringLength(50)]
        public string FC_WarNo { get; set; }

        [StringLength(50)]
        public string FC_ClassID { get; set; }

        [Required]
        [StringLength(200)]
        public string FC_Name { get; set; }

        [Required]
        [StringLength(20)]
        public string FC_WKType { get; set; }

        public bool FB_Enabled { get; set; }

        [StringLength(20)]
        public string FC_DeptID { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_Factory { get; set; }

        public decimal? FN_MaxCapacity { get; set; }

        public decimal? FN_StdCapacity { get; set; }

        public decimal? FN_PassPer { get; set; }

        public int? FN_DayNum { get; set; }

        [StringLength(50)]
        public string FC_ERPFactory { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Pub_Machines> TB_Pub_Machines { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Pub_PSWK> TB_Pub_PSWK { get; set; }

        public virtual TB_Pub_Warehouse TB_Pub_Warehouse { get; set; }

        public virtual TB_Pub_WCClass TB_Pub_WCClass { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Pub_WCQCParms> TB_Pub_WCQCParms { get; set; }
    }
}
