namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Pub_ProcMans
    {
        [Key]
        [StringLength(50)]
        public string FC_Id { get; set; }

        [StringLength(50)]
        public string FC_PSNo { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_Factory { get; set; }

        [StringLength(50)]
        public string FC_MacID { get; set; }

        [StringLength(50)]
        public string FC_EmpCode { get; set; }

        [StringLength(50)]
        public string FC_EmpName { get; set; }

        public decimal? FN_Value1 { get; set; }

        public decimal? FN_Value2 { get; set; }

        public decimal? FN_Value3 { get; set; }

        public decimal? FN_Value4 { get; set; }

        public decimal? FN_Value5 { get; set; }

        public decimal? FN_Value6 { get; set; }

        [StringLength(50)]
        public string FC_Value7 { get; set; }

        [StringLength(50)]
        public string FC_Value8 { get; set; }

        [StringLength(50)]
        public string FC_Value9 { get; set; }

        [StringLength(50)]
        public string FC_Value10 { get; set; }

        [MaxLength(8)]
        public byte[] FD_Ver { get; set; }

        [StringLength(300)]
        public string FC_Remarks { get; set; }

        [Required]
        [StringLength(20)]
        public string FC_Flag { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_CUserID { get; set; }

        public DateTime FD_CDate { get; set; }

        [StringLength(50)]
        public string FC_UUserID { get; set; }

        public DateTime? FD_UDate { get; set; }
    }
}
