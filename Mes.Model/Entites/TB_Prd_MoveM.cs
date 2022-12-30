namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_MoveM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Prd_MoveM()
        {
            TB_Prd_MoveD = new HashSet<TB_Prd_MoveD>();
        }

        [Key]
        [StringLength(50)]
        public string FC_MoveID { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_Factory { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_PONo { get; set; }

        [StringLength(50)]
        public string FC_NewPONo { get; set; }

        [StringLength(20)]
        public string FC_MoveType { get; set; }

        [StringLength(50)]
        public string FC_CMan { get; set; }

        [StringLength(20)]
        public string FC_Flag { get; set; }

        [StringLength(50)]
        public string FC_ConMan { get; set; }

        public DateTime? FD_ConDate { get; set; }

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
        public virtual ICollection<TB_Prd_MoveD> TB_Prd_MoveD { get; set; }
    }
}
