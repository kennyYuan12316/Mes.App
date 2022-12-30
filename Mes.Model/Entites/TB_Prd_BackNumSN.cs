namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_BackNumSN
    {
        [StringLength(50)]
        public string FC_BackNumber { get; set; }

        [StringLength(150)]
        public string FC_SN { get; set; }

        public DateTime? FC_CDate { get; set; }

        [StringLength(50)]
        public string FC_CheckMan { get; set; }

        [StringLength(50)]
        public string FC_PSCode { get; set; }

        [StringLength(50)]
        public string FC_Factory { get; set; }

        [Key]
        public int FC_ID { get; set; }
    }
}
