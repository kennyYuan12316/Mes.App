namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_StoreScrapD
    {
        [Key]
        [StringLength(50)]
        public string FC_ScrapDNo { get; set; }

        [StringLength(50)]
        public string FC_ID { get; set; }

        [StringLength(50)]
        public string FC_ScrapNo { get; set; }

        [StringLength(50)]
        public string FC_BatchNo { get; set; }

        [StringLength(50)]
        public string TB__FC_ID { get; set; }

        [StringLength(20)]
        public string FC_NGCodeNo { get; set; }

        public decimal? FC_BackNum { get; set; }

        [StringLength(300)]
        public string FC_Remarks { get; set; }

        public virtual TB_Prd_StoreScrapM TB_Prd_StoreScrapM { get; set; }
    }
}
