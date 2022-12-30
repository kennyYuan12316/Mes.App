namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_MESPOEX
    {
        [Key]
        [StringLength(50)]
        public string FC_POEXNo { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_Factory { get; set; }

        [StringLength(50)]
        public string FC_PONo { get; set; }

        [StringLength(50)]
        public string FC_POEX { get; set; }

        [StringLength(20)]
        public string FC_Flag { get; set; }

        [StringLength(50)]
        public string FC_EXMan { get; set; }

        public DateTime? FD_EXDate { get; set; }

        [StringLength(300)]
        public string FC_Remark { get; set; }

        public decimal? FN_PONums { get; set; }

        public DateTime? FD_RDate { get; set; }

        [StringLength(50)]
        public string FC_ERPCustNo { get; set; }

        [StringLength(300)]
        public string FC_ERPCustName { get; set; }

        public DateTime? FC_ERPSData { get; set; }

        [StringLength(50)]
        public string FC_SalePNo { get; set; }

        [StringLength(60)]
        public string FC_SalePShape { get; set; }

        public decimal? FN_ERPInPer { get; set; }

        [StringLength(50)]
        public string FC_NGGroup { get; set; }

        [StringLength(50)]
        public string FC_ERPWarNo { get; set; }

        [StringLength(300)]
        public string FC_ERPWarName { get; set; }

        [StringLength(800)]
        public string FC_EXNote { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_CUserID { get; set; }

        public DateTime FD_CDate { get; set; }
    }
}
