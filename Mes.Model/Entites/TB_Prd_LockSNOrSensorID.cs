namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_LockSNOrSensorID
    {
        [Key]
        public long FC_ID { get; set; }

        [StringLength(50)]
        public string FC_SN { get; set; }

        [StringLength(50)]
        public string FC_SensorID { get; set; }

        [StringLength(250)]
        public string FC_LockReason { get; set; }

        [StringLength(50)]
        public string FC_CUser { get; set; }

        public DateTime? FC_CDate { get; set; }

        [StringLength(50)]
        public string FC_PsCode { get; set; }
    }
}
