namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_IncomingMatScrap
    {
        [Key]
        public int FN_ID { get; set; }

        [StringLength(50)]
        public string FC_PoNo { get; set; }

        [StringLength(150)]
        public string FC_MatBarCode { get; set; }

        [StringLength(50)]
        public string FC_NGGroup { get; set; }

        [StringLength(50)]
        public string FC_NGName { get; set; }

        [StringLength(50)]
        public string FC_UserID { get; set; }

        public DateTime? FD_CDate { get; set; }

        public decimal? FN_ScrapNumber { get; set; }

        [StringLength(50)]
        public string FC_SCrapType { get; set; }

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
