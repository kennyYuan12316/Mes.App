namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_MatKeepRight
    {
        [Key]
        [StringLength(100)]
        public string FC_ID { get; set; }

        [StringLength(50)]
        public string FC_Factory { get; set; }

        [StringLength(50)]
        public string FC_WorkNo { get; set; }

        [StringLength(50)]
        public string FC_Seat { get; set; }

        [StringLength(100)]
        public string FC_Mat { get; set; }

        [StringLength(50)]
        public string FC_MachineNo { get; set; }

        [StringLength(50)]
        public string FC_MachineName { get; set; }

        [StringLength(50)]
        public string FC_Shape { get; set; }
    }
}
