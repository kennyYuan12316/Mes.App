namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Pub_ReciveMat
    {
        [Key]
        public int FN_ID { get; set; }

        [StringLength(50)]
        public string FC_MatDuc { get; set; }

        public int? FC_Year { get; set; }

        public int? FN_RowNo { get; set; }

        [StringLength(50)]
        public string FC_MatTranType { get; set; }

        [StringLength(50)]
        public string FC_MatNo { get; set; }

        [StringLength(50)]
        public string FC_Factory { get; set; }

        [StringLength(50)]
        public string FC_InventoryLocation { get; set; }

        [StringLength(50)]
        public string FC_MatBatchNo { get; set; }

        public decimal? FN_Quantity { get; set; }

        [StringLength(50)]
        public string FC_Unit { get; set; }

        [StringLength(50)]
        public string FC_ErpNo { get; set; }

        public int? FN_DemandNo { get; set; }

        public int? FN_DemandRowNo { get; set; }

        [StringLength(50)]
        public string FC_BomRowNo { get; set; }

        public int? FN_YearReversedVoucher { get; set; }

        [StringLength(50)]
        public string FC_ReversalVoucherNo { get; set; }

        public int? FN_ReversedVoucherRowNo { get; set; }

        [StringLength(50)]
        public string FC_PostingNo { get; set; }

        [StringLength(50)]
        public string FC_PostingDocumentDes { get; set; }

        public decimal? FN_ActualIssue { get; set; }

        public DateTime? FD_CDate { get; set; }

        [StringLength(250)]
        public string FC_MatDesc { get; set; }

        [StringLength(50)]
        public string FC_MatType { get; set; }

        [StringLength(50)]
        public string FC_MatGroup { get; set; }
    }
}
