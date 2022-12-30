namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Pub_BalanceMatM
    {
        [Required]
        [StringLength(50)]
        public string FC_PNo { get; set; }

        [Required]
        [StringLength(8)]
        public string FC_Factory { get; set; }

        [Required]
        [StringLength(16)]
        public string FC_UUser { get; set; }

        public DateTime FC_UDate { get; set; }

        [StringLength(255)]
        public string FC_Remarks { get; set; }

        [StringLength(100)]
        public string ID { get; set; }

        [StringLength(150)]
        public string FC_Shape { get; set; }
    }
}
