namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Pub_NGCodes
    {
        [Key]
        [StringLength(50)]
        public string FC_CodeNo { get; set; }

        [StringLength(50)]
        public string FC_Code { get; set; }

        [StringLength(50)]
        public string FC_ClassID { get; set; }

        [StringLength(200)]
        public string FC_Name { get; set; }

        [StringLength(50)]
        public string FC_Type { get; set; }

        [StringLength(50)]
        public string FC_ERPCode { get; set; }

        [StringLength(200)]
        public string FC_ERPName { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_Factory { get; set; }

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

        [StringLength(20)]
        public string FC_RetFlag { get; set; }

        [StringLength(50)]
        public string FC_SFCCode { get; set; }

        [StringLength(50)]
        public string FC_NGCodeNer { get; set; }

        public virtual TB_Pub_NGClass TB_Pub_NGClass { get; set; }
    }
}
