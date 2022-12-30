namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Pub_ProcProdAbility
    {
        [StringLength(50)]
        public string ID { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_PSNo { get; set; }

        public decimal FC_PCSAbility { get; set; }

        [Required]
        [StringLength(8)]
        public string FC_Factory { get; set; }

        [StringLength(255)]
        public string FC_Remarks { get; set; }

        [StringLength(255)]
        public string FC_Remarks1 { get; set; }

        [StringLength(255)]
        public string FC_Remarks2 { get; set; }

        public decimal? FC_Remarks3 { get; set; }

        public decimal? FC_Remarks4 { get; set; }

        public decimal FC_PairAbility { get; set; }
    }
}
