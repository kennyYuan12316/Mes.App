namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_SMTMatSetDetail
    {
        [Key]
        public int FN_ID { get; set; }

        [StringLength(150)]
        public string FC_PID { get; set; }

        [StringLength(50)]
        public string FC_Line { get; set; }

        [StringLength(50)]
        public string FC_MachineNumber { get; set; }

        [StringLength(50)]
        public string FC_MachineTable { get; set; }

        [StringLength(50)]
        public string FC_Track { get; set; }

        [StringLength(50)]
        public string FC_Group { get; set; }

        [StringLength(50)]
        public string FC_Plant { get; set; }

        [StringLength(150)]
        public string FC_MatPNo { get; set; }

        [StringLength(150)]
        public string FC_MatDescription { get; set; }

        [StringLength(50)]
        public string FC_Location { get; set; }

        public int? FC_Qty { get; set; }

        [StringLength(50)]
        public string FC_UserID { get; set; }

        public DateTime? FD_CDate { get; set; }
    }
}
