namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_POSetupEX
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string FC_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_Factory { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string FC_PONo { get; set; }

        public int? FN_TOrder { get; set; }

        public int? FN_Order { get; set; }

        [StringLength(50)]
        public string FC_PSCode { get; set; }

        [StringLength(20)]
        public string FC_WKNo { get; set; }

        [StringLength(20)]
        public string FC_ProcType { get; set; }

        public decimal? FN_StdProcTime { get; set; }

        [StringLength(20)]
        public string FC_BGType { get; set; }

        [Required]
        [StringLength(20)]
        public string FC_TranTypeNo { get; set; }

        public int? FN_ERPOrder { get; set; }

        [StringLength(50)]
        public string FC_ERPOrder { get; set; }

        [StringLength(50)]
        public string FC_ERPCode { get; set; }

        [StringLength(200)]
        public string FC_ERPCoName { get; set; }

        public decimal? FN_ERPStdPT { get; set; }

        [StringLength(50)]
        public string FC_ERPWC { get; set; }

        [StringLength(200)]
        public string FC_ERPWCName { get; set; }

        [StringLength(50)]
        public string FC_ERPPTNo { get; set; }

        [StringLength(200)]
        public string FC_ERPPTName { get; set; }

        [StringLength(20)]
        public string FC_ERPBG { get; set; }

        public decimal? FN_ERPPer { get; set; }

        [StringLength(50)]
        public string FC_ERPUnit { get; set; }

        public decimal? FN_ERPPSNums { get; set; }

        [StringLength(50)]
        public string FC_ERPConFlag { get; set; }

        public DateTime? FD_ERPSDate { get; set; }

        public DateTime? FD_ERPEDate { get; set; }

        [StringLength(20)]
        public string FC_ClientType { get; set; }

        [StringLength(20)]
        public string FC_TSType { get; set; }

        [StringLength(20)]
        public string FC_ConMan { get; set; }

        [StringLength(20)]
        public string FC_ConMPar { get; set; }

        [StringLength(20)]
        public string FC_ConPPar { get; set; }

        [StringLength(20)]
        public string FC_ConLabPar { get; set; }

        [StringLength(20)]
        public string FC_ConPCSPar { get; set; }

        [StringLength(20)]
        public string FC_ScanIDT1 { get; set; }

        [StringLength(20)]
        public string FC_ScanIDT2 { get; set; }

        [StringLength(20)]
        public string FC_ScanIDT3 { get; set; }

        [StringLength(50)]
        public string FN_OOrder { get; set; }

        [StringLength(50)]
        public string FC_OPSCode { get; set; }

        [StringLength(20)]
        public string FC_OProcType { get; set; }

        [StringLength(20)]
        public string FC_OTranTypeNo { get; set; }

        [StringLength(20)]
        public string FC_OBGType { get; set; }

        public decimal? FN_OStdProcTime { get; set; }
    }
}
