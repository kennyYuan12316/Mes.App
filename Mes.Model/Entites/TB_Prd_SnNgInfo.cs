namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_SnNgInfo
    {
        [Key]
        public int FN_ID { get; set; }

        [StringLength(150)]
        public string FC_SN { get; set; }

        [StringLength(180)]
        public string FC_PackSN { get; set; }

        [StringLength(50)]
        public string FC_PSCode { get; set; }

        [StringLength(50)]
        public string FC_UserID { get; set; }

        public DateTime? FD_DateTime { get; set; }

        [StringLength(150)]
        public string FC_NgMsg { get; set; }

        [StringLength(50)]
        public string FC_MachineNo { get; set; }

        [StringLength(50)]
        public string FC_Sharp { get; set; }
    }
}
