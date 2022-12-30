namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_BatchUseMat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Prd_BatchUseMat()
        {
            TB_Prd_BatchUseMatD = new HashSet<TB_Prd_BatchUseMatD>();
        }

        [Key]
        [StringLength(50)]
        public string FC_UseMatNo { get; set; }

        [StringLength(50)]
        public string FC_UseMan { get; set; }

        [StringLength(50)]
        public string FC_SendMan { get; set; }

        public DateTime? FD_SendDate { get; set; }

        [StringLength(50)]
        public string FC_ConMan { get; set; }

        public DateTime? FD_ConDate { get; set; }

        [StringLength(50)]
        public string FC_OutWar { get; set; }

        [StringLength(50)]
        public string FC_InWar { get; set; }

        [StringLength(20)]
        public string FC_Flag { get; set; }

        [StringLength(300)]
        public string FC_Remarks { get; set; }

        [Required]
        [StringLength(20)]
        public string FC_RowFlag { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_PONo { get; set; }

        [StringLength(50)]
        public string FC_ERPPO { get; set; }

        [StringLength(50)]
        public string FC_PSID { get; set; }

        [StringLength(50)]
        public string FC_PSCode { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_BatchNo { get; set; }

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

        [StringLength(50)]
        public string FC_UseWC { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_Factory { get; set; }

        [StringLength(50)]
        public string FC_MachineNo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Prd_BatchUseMatD> TB_Prd_BatchUseMatD { get; set; }
    }
}
