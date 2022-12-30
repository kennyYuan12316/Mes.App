namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Pub_RoutingPlanD
    {
        [Key]
        [StringLength(50)]
        public string FC_ID { get; set; }

        [StringLength(50)]
        public string FC_No { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_Factory { get; set; }

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

        public int? FN_TestCountControl { get; set; }

        public int? FN_CurrPSTimeControl { get; set; }

        public int? FN_PrePSTimeControl { get; set; }

        [StringLength(20)]
        public string FC_CurrPSControlCondition { get; set; }

        [StringLength(20)]
        public string FC_PrePSControlCondition { get; set; }

        [StringLength(150)]
        public string FC_SoftVersion { get; set; }

        [StringLength(4)]
        public string FC_ReleaseDeviceFlag { get; set; }

        public virtual TB_Pub_RoutingPlanM TB_Pub_RoutingPlanM { get; set; }
    }
}
