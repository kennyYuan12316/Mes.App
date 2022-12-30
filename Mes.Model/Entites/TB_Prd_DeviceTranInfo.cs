namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_DeviceTranInfo
    {
        [Key]
        [StringLength(50)]
        public string FC_TranNo { get; set; }

        [StringLength(50)]
        public string FC_PONo { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_SID { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_PSCode { get; set; }

        [StringLength(50)]
        public string FC_BatchNo { get; set; }

        [StringLength(50)]
        public string FC_DeviceID { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_Factory { get; set; }

        public decimal? FN_InNums { get; set; }

        public decimal? FN_OutNums { get; set; }

        public decimal? FN_NgNums { get; set; }

        [StringLength(50)]
        public string FC_ProcWK { get; set; }

        public decimal? FN_ProcHours { get; set; }

        public int? FN_ProcMans { get; set; }

        public decimal? FN_MacHours { get; set; }

        public decimal? FN_OtherHours { get; set; }

        public DateTime? FD_SDate { get; set; }

        public DateTime? FD_FDate { get; set; }

        [StringLength(50)]
        public string FC_ChkMan { get; set; }

        [Required]
        [StringLength(20)]
        public string FC_BCType { get; set; }

        [StringLength(300)]
        public string FC_Remarks { get; set; }

        [Required]
        [StringLength(20)]
        public string FC_RowFlag { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_CUserID { get; set; }

        public DateTime FD_CDate { get; set; }

        [StringLength(50)]
        public string FC_UUserID { get; set; }

        public DateTime? FD_UDate { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] FD_Ver { get; set; }

        public bool? FB_ERPBG { get; set; }

        public bool? FB_ERPBGFlag { get; set; }

        public DateTime? FD_ERPBGDate { get; set; }

        [StringLength(20)]
        public string FC_RecManFlag { get; set; }

        [StringLength(50)]
        public string FC_RecMan { get; set; }

        public DateTime? FD_RecConDate { get; set; }

        [StringLength(50)]
        public string FC_ERPBGNo { get; set; }

        [StringLength(50)]
        public string FC_ERPBGCount { get; set; }

        public int? FN_BGCount { get; set; }

        public decimal? FN_RecNums { get; set; }

        [StringLength(20)]
        public string FC_PWType { get; set; }

        public decimal? FN_AccBGNums { get; set; }

        [StringLength(20)]
        public string FC_SplitFlag { get; set; }

        public decimal? FN_SplitNums { get; set; }

        [StringLength(20)]
        public string FC_TranTypeNo { get; set; }

        [StringLength(20)]
        public string FC_NeedBG { get; set; }

        [StringLength(50)]
        public string FC_MacNo { get; set; }
    }
}
