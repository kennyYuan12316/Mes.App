namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Pub_CurrentReciveMat
    {
        [Key]
        public int FN_ID { get; set; }

        [StringLength(50)]
        public string FC_ERPNo { get; set; }

        [StringLength(50)]
        public string FC_MatNo { get; set; }

        [StringLength(250)]
        public string FC_MatDesc { get; set; }

        public DateTime? FD_CDate { get; set; }

        public DateTime? FD_UDate { get; set; }

        public decimal? FN_ActualIssue { get; set; }
    }
}
