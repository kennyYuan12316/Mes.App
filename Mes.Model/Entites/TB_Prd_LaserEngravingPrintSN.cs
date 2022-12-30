namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_LaserEngravingPrintSN
    {
        [Key]
        [StringLength(150)]
        public string FC_SN { get; set; }

        [StringLength(50)]
        public string FC_PONO { get; set; }

        [StringLength(250)]
        public string FC_FPCNo { get; set; }

        [StringLength(250)]
        public string FC_FPCNoBehind { get; set; }

        [StringLength(50)]
        public string FC_CUserID { get; set; }

        public DateTime? FD_CDate { get; set; }

        [StringLength(50)]
        public string FC_FPCBatchNo { get; set; }

        [StringLength(50)]
        public string FC_MachineNo { get; set; }
    }
}
