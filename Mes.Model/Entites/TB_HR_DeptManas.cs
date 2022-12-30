namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_HR_DeptManas
    {
        [Key]
        [StringLength(50)]
        public string FC_ManaNo { get; set; }

        [StringLength(50)]
        public string FC_DeptID { get; set; }

        [StringLength(50)]
        public string FC_EmpID { get; set; }

        [StringLength(50)]
        public string FC_ManaID { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_ProxEmpID { get; set; }

        [StringLength(100)]
        public string FC_ExtInfo { get; set; }

        [StringLength(200)]
        public string FC_Description { get; set; }

        public int? FN_RowFlag { get; set; }

        [Required]
        [StringLength(20)]
        public string FC_CUserID { get; set; }

        public DateTime FD_CDate { get; set; }

        [StringLength(20)]
        public string FC_UUserID { get; set; }

        public DateTime? FD_UDate { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] FD_Version { get; set; }
    }
}
