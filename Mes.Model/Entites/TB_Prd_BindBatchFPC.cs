namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_BindBatchFPC
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FN_ID { get; set; }

        [StringLength(4)]
        public string FC_Factory { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string FC_BatchNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(150)]
        public string FC_FPCNo { get; set; }

        [StringLength(50)]
        public string FC_PoNo { get; set; }

        [StringLength(50)]
        public string FC_PNo { get; set; }

        [StringLength(150)]
        public string FC_Sharp { get; set; }

        public int? FB_BatchNum { get; set; }

        public int? FB_FPCNum { get; set; }

        public int? FB_BatchDownNum { get; set; }

        public int? FB_FPCDwonNum { get; set; }

        [StringLength(50)]
        public string FC_PSCode { get; set; }

        public bool? FB_BatchStatus { get; set; }

        public bool? FB_FPCStatus { get; set; }

        [StringLength(50)]
        public string FC_UserID { get; set; }

        public DateTime? FD_CDate { get; set; }

        [StringLength(50)]
        public string FC_UPUserID { get; set; }

        public DateTime? FD_UDate { get; set; }

        [StringLength(150)]
        public string FC_FPCNoNew { get; set; }
    }
}
