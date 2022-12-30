namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_DayPlan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Prd_DayPlan()
        {
            TB_Prd_DayPlanD = new HashSet<TB_Prd_DayPlanD>();
        }

        [Key]
        [StringLength(50)]
        public string FC_PlanNo { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_Factory { get; set; }

        public DateTime? FD_PlanDay { get; set; }

        [StringLength(20)]
        public string FC_ClassNo { get; set; }

        [StringLength(20)]
        public string FC_PlanMan { get; set; }

        [StringLength(20)]
        public string FC_Flag { get; set; }

        public DateTime? FD_SDate { get; set; }

        public DateTime? FD_EDate { get; set; }

        public DateTime? FD_SendDate { get; set; }

        [StringLength(20)]
        public string FC_SendMan { get; set; }

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

        [StringLength(100)]
        public string FC_PlanName { get; set; }

        [StringLength(50)]
        public string FC_ChkMan { get; set; }

        public DateTime? FD_ChkDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Prd_DayPlanD> TB_Prd_DayPlanD { get; set; }
    }
}
