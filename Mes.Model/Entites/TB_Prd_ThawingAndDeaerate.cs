namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_ThawingAndDeaerate
    {
        [Key]
        public int FN_ID { get; set; }

        [StringLength(50)]
        public string FC_BarCode { get; set; }

        [StringLength(50)]
        public string FC_OpreType { get; set; }

        public DateTime? FD_CDate { get; set; }

        [StringLength(50)]
        public string FC_UserID { get; set; }
    }
}
