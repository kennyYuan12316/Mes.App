namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Pub_RoutingPlanM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Pub_RoutingPlanM()
        {
            TB_Pub_RoutingPlanD = new HashSet<TB_Pub_RoutingPlanD>();
        }

        [Key]
        [StringLength(50)]
        public string FC_No { get; set; }

        [StringLength(50)]
        public string FC_ClassNO { get; set; }

        [Required]
        [StringLength(300)]
        public string FC_Name { get; set; }

        [StringLength(20)]
        public string FC_Type { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_Factory { get; set; }

        public bool FB_Enabled { get; set; }

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
        public virtual ICollection<TB_Pub_RoutingPlanD> TB_Pub_RoutingPlanD { get; set; }

        public virtual TB_Pub_RPlanType TB_Pub_RPlanType { get; set; }
    }
}
