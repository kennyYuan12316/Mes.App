namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_PickingMat
    {
        [Key]
        public int FN_ID { get; set; }

        [StringLength(4)]
        public string FC_Factory { get; set; }

        [StringLength(50)]
        public string FC_PoNo { get; set; }

        [StringLength(50)]
        public string FC_MatBarCode { get; set; }

        [StringLength(50)]
        public string FC_MatType { get; set; }

        [StringLength(50)]
        public string FC_PSCode { get; set; }

        [StringLength(50)]
        public string FC_UserID { get; set; }

        public DateTime? FD_CDate { get; set; }

        public decimal? FN_PickNumber { get; set; }

        [StringLength(50)]
        public string FC_PNo { get; set; }

        [StringLength(250)]
        public string FC_PNoDesc { get; set; }

        public decimal? FN_StanderNumber { get; set; }

        public decimal? FN_RemainNumber { get; set; }

        [StringLength(50)]
        public string FC_PSName { get; set; }

        public decimal? FN_UseNumber { get; set; }
    }
}
