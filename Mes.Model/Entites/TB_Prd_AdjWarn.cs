namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_AdjWarn
    {
        [Key]
        [StringLength(100)]
        public string FC_ID { get; set; }

        [Required]
        [StringLength(255)]
        public string FC_BarCode { get; set; }

        public DateTime FC_GetTime { get; set; }

        public DateTime FC_ThawTime { get; set; }

        public DateTime FC_ActiveTime { get; set; }

        public int FC_Flag { get; set; }

        [StringLength(50)]
        public string FC_Prompt { get; set; }
    }
}
