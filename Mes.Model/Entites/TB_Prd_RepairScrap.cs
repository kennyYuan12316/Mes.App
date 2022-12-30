namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_RepairScrap
    {
        [Key]
        public int FN_ID { get; set; }

        [StringLength(50)]
        public string FC_PONo { get; set; }

        [StringLength(50)]
        public string FC_BatchNo { get; set; }

        [StringLength(150)]
        public string FC_SN { get; set; }

        [StringLength(150)]
        public string FC_BarCode { get; set; }

        [StringLength(50)]
        public string FC_CUserID { get; set; }

        public DateTime? FD_CDate { get; set; }

        [StringLength(50)]
        public string FC_UUserID { get; set; }

        public DateTime? FD_UDate { get; set; }

        public decimal? FN_SCrapNum { get; set; }

        [StringLength(50)]
        public string FC_PNo { get; set; }

        [StringLength(150)]
        public string FC_Shape { get; set; }

        [StringLength(50)]
        public string FC_MatPNo { get; set; }

        [StringLength(150)]
        public string FC_MatPNoDesc { get; set; }
    }
}
