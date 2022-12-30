namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_HR_Employees
    {
        [Key]
        [StringLength(50)]
        public string FC_EmpID { get; set; }

        [StringLength(50)]
        public string FC_DeptID { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_EmpCode { get; set; }

        [Required]
        [StringLength(60)]
        public string FC_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_Sex { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_WorkStatus { get; set; }

        [StringLength(50)]
        public string FC_WorkType { get; set; }

        [StringLength(150)]
        public string FC_WorkAddr { get; set; }

        [StringLength(50)]
        public string FC_ID { get; set; }

        public DateTime? FD_Birthday { get; set; }

        [StringLength(50)]
        public string FC_Edu { get; set; }

        public DateTime? FD_ComeDay { get; set; }

        [StringLength(50)]
        public string FC_Nation { get; set; }

        [StringLength(50)]
        public string FC_Tel { get; set; }

        [StringLength(50)]
        public string FC_Mobel { get; set; }

        [StringLength(150)]
        public string FC_EMail { get; set; }

        [StringLength(50)]
        public string FC_QQ { get; set; }

        [StringLength(150)]
        public string FC_WeiXi { get; set; }

        [Column(TypeName = "image")]
        public byte[] FB_EQM { get; set; }

        [Column(TypeName = "image")]
        public byte[] FB_Photo { get; set; }

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
