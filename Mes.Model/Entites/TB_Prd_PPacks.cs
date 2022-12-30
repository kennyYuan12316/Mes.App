namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_PPacks
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Prd_PPacks()
        {
            TB_Prd_PPacksD = new HashSet<TB_Prd_PPacksD>();
        }

        [Key]
        [StringLength(50)]
        public string FC_PID { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_Factory { get; set; }

        [StringLength(50)]
        public string FC_PNo { get; set; }

        [StringLength(50)]
        public string FC_PVer { get; set; }

        [StringLength(300)]
        public string FC_PName { get; set; }

        [StringLength(300)]
        public string FC_Shape { get; set; }

        [StringLength(50)]
        public string FC_Unit { get; set; }

        [StringLength(500)]
        public string FC_Ext1 { get; set; }

        [StringLength(255)]
        public string FC_Ext2 { get; set; }

        [StringLength(500)]
        public string FC_Ext3 { get; set; }

        [StringLength(500)]
        public string FC_Ext4 { get; set; }

        [StringLength(500)]
        public string FC_Ext5 { get; set; }

        [StringLength(500)]
        public string FC_Ext6 { get; set; }

        [StringLength(500)]
        public string FC_Ext7 { get; set; }

        [StringLength(500)]
        public string FC_Ext8 { get; set; }

        [StringLength(500)]
        public string FC_Ext9 { get; set; }

        [StringLength(500)]
        public string FC_Ext10 { get; set; }

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

        [StringLength(120)]
        public string FC_PrdLabRegular { get; set; }

        [StringLength(1000)]
        public string FC_SNSql { get; set; }

        [StringLength(100)]
        public string FC_SNFix1 { get; set; }

        [StringLength(100)]
        public string FC_SNFix2 { get; set; }

        [StringLength(100)]
        public string FC_SNFix3 { get; set; }

        [StringLength(100)]
        public string FC_SNFix4 { get; set; }

        [StringLength(200)]
        public string FC_Field1 { get; set; }

        [StringLength(200)]
        public string FC_Field2 { get; set; }

        [StringLength(200)]
        public string FC_Field3 { get; set; }

        [StringLength(200)]
        public string FC_Field4 { get; set; }

        [StringLength(200)]
        public string FC_Field5 { get; set; }

        [StringLength(200)]
        public string FC_Field6 { get; set; }

        [StringLength(200)]
        public string FC_Field7 { get; set; }

        [StringLength(200)]
        public string FC_Field8 { get; set; }

        [StringLength(200)]
        public string FC_Field9 { get; set; }

        [StringLength(200)]
        public string FC_Field10 { get; set; }

        [StringLength(200)]
        public string FC_BYDSupNo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Prd_PPacksD> TB_Prd_PPacksD { get; set; }
    }
}
