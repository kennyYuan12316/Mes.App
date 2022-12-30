namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_ProcMans
    {
        [Key]
        [StringLength(50)]
        public string FC_RecNo { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_Factory { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_TranNo { get; set; }

        public decimal FN_Nums { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_EmpCode { get; set; }

        [StringLength(300)]
        public string FC_Remarks { get; set; }

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

        public virtual TB_Prd_TranInfo TB_Prd_TranInfo { get; set; }
    }
}
