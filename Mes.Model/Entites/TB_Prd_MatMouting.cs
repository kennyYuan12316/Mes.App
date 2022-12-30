namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_MatMouting
    {
        [Key]
        public long FN_ID { get; set; }

        [StringLength(50)]
        public string FC_PSCode { get; set; }

        [StringLength(50)]
        public string FC_PSName { get; set; }

        [StringLength(4)]
        public string FC_Factory { get; set; }

        [StringLength(50)]
        public string FC_PONo { get; set; }

        [StringLength(50)]
        public string FC_FPCNo { get; set; }

        [StringLength(50)]
        public string FC_DeviceID { get; set; }

        [StringLength(50)]
        public string FC_BatchNo { get; set; }

        [StringLength(150)]
        public string FC_MatBarCode { get; set; }

        public DateTime? FD_CDateTime { get; set; }

        [StringLength(50)]
        public string FC_UserID { get; set; }

        [StringLength(50)]
        public string FC_WorkCenter { get; set; }

        [StringLength(50)]
        public string FC_LineID { get; set; }

        [StringLength(50)]
        public string FC_MachineNo { get; set; }

        [StringLength(150)]
        public string FC_Shape { get; set; }

        [StringLength(50)]
        public string FC_MatTable { get; set; }

        [StringLength(250)]
        public string FC_MatType { get; set; }

        [StringLength(50)]
        public string FC_MatPNo { get; set; }

        public decimal? FN_UseNumber { get; set; }
    }
}
