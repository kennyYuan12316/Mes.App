namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_MoveD
    {
        [Key]
        [StringLength(50)]
        public string FC_DID { get; set; }

        [StringLength(50)]
        public string FC_MoveID { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_BatchNo { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_NewBNo { get; set; }

        public decimal? FN_Nums { get; set; }

        public virtual TB_Prd_MoveM TB_Prd_MoveM { get; set; }
    }
}
