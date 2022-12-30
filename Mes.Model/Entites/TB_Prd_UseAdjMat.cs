namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_UseAdjMat
    {
        [Required]
        [StringLength(50)]
        public string FC_BatchNo { get; set; }

        [StringLength(50)]
        public string FC_PONO { get; set; }

        [Required]
        [StringLength(250)]
        public string FC_BarCode { get; set; }

        [StringLength(50)]
        public string FC_FC_AJPNo { get; set; }

        [StringLength(50)]
        public string FC_UseMatMan { get; set; }

        public DateTime? FC_UseTime { get; set; }

        [StringLength(10)]
        public string FC_UseFlag { get; set; }

        [StringLength(50)]
        public string FC_Remark { get; set; }

        [StringLength(50)]
        public string FC_Factory { get; set; }

        [StringLength(50)]
        public string FC_PNO { get; set; }

        [StringLength(50)]
        public string FC_ERPNo { get; set; }

        [StringLength(150)]
        public string FC_Spec { get; set; }

        [StringLength(50)]
        public string FC_MachineNo { get; set; }

        [StringLength(50)]
        public string FC_PSCode { get; set; }

        [StringLength(50)]
        public string FC_WorkCenter { get; set; }

        [StringLength(50)]
        public string FC_FC_AJPName { get; set; }

        public int? FC_UseNum { get; set; }

        public int? FC_ActiveTime { get; set; }

        public int? FC_ActiveCount { get; set; }

        [Key]
        [StringLength(100)]
        public string FC_ID { get; set; }

        [StringLength(50)]
        public string FC_FBatchNo { get; set; }
    }
}
