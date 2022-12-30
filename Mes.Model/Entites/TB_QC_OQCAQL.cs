namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_QC_OQCAQL
    {
        [Key]
        [StringLength(50)]
        public string FC_ID { get; set; }

        [StringLength(50)]
        public string FC_BatchNo { get; set; }

        [StringLength(20)]
        public string FC_WorkCenter { get; set; }

        public int? FN_AQLQty { get; set; }

        public int? FN_GoodQty { get; set; }

        public int? FN_BadQty { get; set; }

        [StringLength(50)]
        public string FC_Factory { get; set; }

        [StringLength(50)]
        public string FC_CUserID { get; set; }

        public DateTime FD_CDate { get; set; }

        [StringLength(50)]
        public string FC_UUserID { get; set; }

        public DateTime FD_UDate { get; set; }
    }
}
