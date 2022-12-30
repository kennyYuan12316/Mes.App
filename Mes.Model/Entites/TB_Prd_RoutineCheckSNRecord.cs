namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_RoutineCheckSNRecord
    {
        [Key]
        public int FN_ID { get; set; }

        [StringLength(150)]
        public string FC_SN { get; set; }

        [StringLength(50)]
        public string FC_PSCode { get; set; }

        [StringLength(150)]
        public string FC_Shape { get; set; }

        [StringLength(50)]
        public string FC_UserID { get; set; }

        public DateTime? FD_CDate { get; set; }

        [StringLength(50)]
        public string FC_Factory { get; set; }
    }
}
