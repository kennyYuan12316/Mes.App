namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_TranInfoLog
    {
        [Key]
        [StringLength(50)]
        public string FC_ID { get; set; }

        [StringLength(50)]
        public string FC_TranNo { get; set; }

        [StringLength(50)]
        public string FC_ERPPO { get; set; }

        [Column(TypeName = "text")]
        public string FC_Message { get; set; }

        public DateTime FD_CDate { get; set; }

        [StringLength(50)]
        public string FC_BatchNo { get; set; }
    }
}
