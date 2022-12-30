namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_BatchBackMat
    {
        [StringLength(50)]
        public string FC_BatchNo { get; set; }

        [StringLength(50)]
        public string FC_PONo { get; set; }

        [StringLength(50)]
        public string FC_PNo { get; set; }

        [StringLength(150)]
        public string ID { get; set; }

        [StringLength(50)]
        public string FC_BackUser { get; set; }

        public DateTime? FC_BackDate { get; set; }

        [StringLength(4)]
        public string FC_Factory { get; set; }

        [StringLength(50)]
        public string FC_ERPNo { get; set; }
    }
}
