namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_StoreScrapSND
    {
        [Key]
        [StringLength(50)]
        public string FC_ScrapSNNo { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_ScrapNo { get; set; }

        [Required]
        [StringLength(150)]
        public string FC_SN { get; set; }

        [StringLength(50)]
        public string FC_UDF01 { get; set; }

        [StringLength(50)]
        public string FC_UDF02 { get; set; }

        [StringLength(50)]
        public string FC_UDF03 { get; set; }

        [StringLength(250)]
        public string FC_UDF04 { get; set; }

        [StringLength(250)]
        public string FC_UDF05 { get; set; }

        public virtual TB_Prd_StoreScrapM TB_Prd_StoreScrapM { get; set; }
    }
}
