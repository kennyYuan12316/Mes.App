namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_UnBindSNLog
    {
        [Key]
        public int FC_ID { get; set; }

        [StringLength(150)]
        public string FC_SN { get; set; }

        [StringLength(150)]
        public string FC_FuseID { get; set; }

        public DateTime? FD_CDate { get; set; }

        [StringLength(150)]
        public string FC_CUser { get; set; }

        [StringLength(150)]
        public string FC_MachineNo { get; set; }
    }
}
