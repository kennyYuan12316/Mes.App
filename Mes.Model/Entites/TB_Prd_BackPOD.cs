namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_BackPOD
    {
        [Key]
        [StringLength(50)]
        public string FC_BackDNo { get; set; }

        [StringLength(50)]
        public string FC_BackNo { get; set; }

        [StringLength(50)]
        public string FC_ID { get; set; }

        [StringLength(20)]
        public string FC_NGCodeNo { get; set; }

        [StringLength(50)]
        public string FC_NGGroup { get; set; }

        public decimal? FC_BackNum { get; set; }

        [StringLength(300)]
        public string FC_Remarks { get; set; }

        public virtual TB_Prd_BackPOM TB_Prd_BackPOM { get; set; }

        public virtual TB_Prd_Stocks TB_Prd_Stocks { get; set; }
    }
}
