namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_RepairIn
    {
        [Key]
        public int FN_ID { get; set; }

        [StringLength(50)]
        public string FC_Factroy { get; set; }

        [StringLength(50)]
        public string FC_PO { get; set; }

        [StringLength(50)]
        public string FC_BatchNo { get; set; }

        [StringLength(150)]
        public string FC_SN { get; set; }

        [StringLength(50)]
        public string FC_NgGroup { get; set; }

        [StringLength(50)]
        public string FC_NGCode { get; set; }

        [StringLength(250)]
        public string FC_NGDetail { get; set; }

        [StringLength(50)]
        public string FC_WorkCenter { get; set; }

        [StringLength(50)]
        public string FC_PSCode { get; set; }

        [StringLength(50)]
        public string FC_PSName { get; set; }

        [StringLength(50)]
        public string FC_LineID { get; set; }

        [StringLength(50)]
        public string FC_RepairUser { get; set; }

        [StringLength(150)]
        public string FC_Shape { get; set; }

        public DateTime? FD_CDate { get; set; }

        [StringLength(50)]
        public string FC_RePairType { get; set; }

        [StringLength(50)]
        public string FC_CurrentBatchNo { get; set; }
    }
}
