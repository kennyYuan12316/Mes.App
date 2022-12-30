namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_FPCBindMat
    {
        [Key]
        public long FC_ID { get; set; }

        [StringLength(50)]
        public string FC_BatchNo { get; set; }

        [StringLength(50)]
        public string FC_PoNo { get; set; }

        [StringLength(50)]
        public string FC_FPCNo { get; set; }

        [StringLength(50)]
        public string FC_Factory { get; set; }

        [StringLength(150)]
        public string FC_Shape { get; set; }

        [StringLength(50)]
        public string FC_PNo { get; set; }

        [StringLength(50)]
        public string FC_WorkCenter { get; set; }

        [StringLength(50)]
        public string FC_PSCode { get; set; }

        [StringLength(50)]
        public string FC_PSName { get; set; }

        [StringLength(50)]
        public string FC_UserID { get; set; }

        [StringLength(150)]
        public string FC_MatBarCode { get; set; }

        [StringLength(50)]
        public string FC_LineID { get; set; }

        [StringLength(50)]
        public string FC_MachineNo { get; set; }

        [StringLength(50)]
        public string FC_MatType { get; set; }

        public DateTime? FD_CDate { get; set; }
    }
}
