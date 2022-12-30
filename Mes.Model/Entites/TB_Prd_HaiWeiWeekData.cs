namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_HaiWeiWeekData
    {
        [Key]
        public int FN_ID { get; set; }

        [StringLength(50)]
        public string FC_WeekCode { get; set; }

        [StringLength(50)]
        public string FC_WeekDesc { get; set; }

        public DateTime? FD_DayStart { get; set; }

        public DateTime? FD_DayEnd { get; set; }
    }
}
