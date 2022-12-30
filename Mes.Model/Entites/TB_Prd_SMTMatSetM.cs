namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_SMTMatSetM
    {
        [Key]
        public int FN_ID { get; set; }

        [StringLength(50)]
        public string FC_ASYM { get; set; }

        [StringLength(50)]
        public string FC_ProgrameName { get; set; }

        [StringLength(50)]
        public string FC_ModelName { get; set; }

        [StringLength(50)]
        public string FC_Date { get; set; }

        [StringLength(50)]
        public string FC_PCBANo { get; set; }

        [StringLength(50)]
        public string FC_Version { get; set; }

        [StringLength(50)]
        public string FC_PreparedBy { get; set; }

        [StringLength(50)]
        public string FC_ApprovedBy { get; set; }

        [StringLength(50)]
        public string FC_UserID { get; set; }

        public DateTime? FC_CDate { get; set; }

        [StringLength(150)]
        public string FC_PID { get; set; }

        public bool? FB_IsSeclect { get; set; }
    }
}
