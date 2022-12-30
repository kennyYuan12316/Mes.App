namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_RecordSN
    {
        [Key]
        public int FC_ID { get; set; }

        [StringLength(50)]
        public string FC_Date { get; set; }

        [StringLength(50)]
        public string FC_SNID { get; set; }

        public int? FC_Num { get; set; }
    }
}
