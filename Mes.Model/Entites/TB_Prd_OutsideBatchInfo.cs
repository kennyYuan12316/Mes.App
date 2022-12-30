namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_OutsideBatchInfo
    {
        [Key]
        public int FN_ID { get; set; }

        [StringLength(50)]
        public string FC_BatchNo { get; set; }

        public decimal? FC_PickNumber { get; set; }

        public decimal? FC_UseNumber { get; set; }

        public decimal? FC_RemainNumber { get; set; }
    }
}
