namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_QC_SPCRecD
    {
        [Key]
        [StringLength(50)]
        public string FC_ID { get; set; }

        [StringLength(50)]
        public string FC_PDId { get; set; }

        [StringLength(50)]
        public string FC_CheckNo { get; set; }

        public decimal FN_CheckValue { get; set; }

        public int? FN_Order { get; set; }

        [StringLength(300)]
        public string FC_Remarks { get; set; }

        public virtual TB_QC_SPCRec TB_QC_SPCRec { get; set; }
    }
}
