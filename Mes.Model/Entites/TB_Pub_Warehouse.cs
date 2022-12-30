namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Pub_Warehouse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Pub_Warehouse()
        {
            TB_Prd_RecMats = new HashSet<TB_Prd_RecMats>();
            TB_Prd_Stocks = new HashSet<TB_Prd_Stocks>();
            TB_Pub_WorkCenter = new HashSet<TB_Pub_WorkCenter>();
        }

        [Key]
        [StringLength(50)]
        public string FC_WarNo { get; set; }

        [StringLength(50)]
        public string FC_ClassID { get; set; }

        [StringLength(200)]
        public string FC_WarName { get; set; }

        [Required]
        [StringLength(20)]
        public string FC_Type { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_Factory { get; set; }

        [StringLength(200)]
        public string FC_ERPName { get; set; }

        [StringLength(50)]
        public string FC_ERPNo { get; set; }

        public bool FB_Enabled { get; set; }

        [StringLength(20)]
        public string FC_Flag { get; set; }

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

        public bool? FB_ERPRec { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Prd_RecMats> TB_Prd_RecMats { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Prd_Stocks> TB_Prd_Stocks { get; set; }

        public virtual TB_Pub_WarClass TB_Pub_WarClass { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Pub_WorkCenter> TB_Pub_WorkCenter { get; set; }
    }
}
