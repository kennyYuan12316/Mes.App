namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_BatchUseMatD
    {
        [Key]
        [StringLength(50)]
        public string FC_UseMatDNo { get; set; }

        [StringLength(50)]
        public string FC_POMatNo { get; set; }

        [StringLength(50)]
        public string FC_UseMatNo { get; set; }

        [StringLength(50)]
        public string FC_MatNo { get; set; }

        [StringLength(200)]
        public string FC_MatName { get; set; }

        [StringLength(200)]
        public string FC_Shape { get; set; }

        public decimal? FN_ReqNums { get; set; }

        public decimal? FN_UseNums { get; set; }

        public decimal? FN_BackNums { get; set; }

        [StringLength(50)]
        public string FC_Unit { get; set; }

        [StringLength(50)]
        public string FC_WarID { get; set; }

        [StringLength(300)]
        public string FC_Remarks { get; set; }

        [StringLength(50)]
        public string FC_BatchNo { get; set; }

        [StringLength(50)]
        public string FC_PSID { get; set; }

        [StringLength(50)]
        public string FC_PSCode { get; set; }

        [StringLength(50)]
        public string FC_ErpRecBNo { get; set; }

        [StringLength(300)]
        public string FC_MatSN { get; set; }

        [StringLength(50)]
        public string FC_SuprNo { get; set; }

        [StringLength(50)]
        public string FC_DateCode { get; set; }

        [StringLength(50)]
        public string FC_Spare { get; set; }

        [StringLength(1)]
        public string Spare { get; set; }

        public int? FC_Spare1 { get; set; }

        [StringLength(1)]
        public string FC_Spare2 { get; set; }

        public virtual TB_Prd_BatchUseMat TB_Prd_BatchUseMat { get; set; }

        public virtual TB_Prd_RecMats TB_Prd_RecMats { get; set; }
    }
}
