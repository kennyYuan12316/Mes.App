namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_ArrangeStatus
    {
        public int ID { get; set; }

        public DateTime? FC_AffirmDate { get; set; }

        [StringLength(50)]
        public string FC_BatchNo { get; set; }

        public bool? FC_FinishFlag { get; set; }

        [StringLength(50)]
        public string FC_ID { get; set; }

        [StringLength(50)]
        public string FC_OrderID { get; set; }

        [MaxLength(50)]
        public byte[] FC_Remarks1 { get; set; }

        [StringLength(50)]
        public string FC_Remarks2 { get; set; }

        [StringLength(50)]
        public string FC_Remarks3 { get; set; }

        [StringLength(50)]
        public string FC_Remarks4 { get; set; }

        public int? FC_Status { get; set; }
    }
}
