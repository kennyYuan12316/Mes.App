namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_War_StoreExcD
    {
        [Key]
        [StringLength(50)]
        public string FC_EXNoD { get; set; }

        [StringLength(50)]
        public string FC_ExNo { get; set; }

        [StringLength(50)]
        public string FD_PONo { get; set; }

        [StringLength(50)]
        public string FC_StockD { get; set; }

        [StringLength(50)]
        public string FC_PNo { get; set; }

        [StringLength(50)]
        public string FC_Shape { get; set; }

        public decimal? FC_EXNums { get; set; }

        [StringLength(300)]
        public string FC_Remarks { get; set; }

        public virtual TB_War_StoreExcM TB_War_StoreExcM { get; set; }
    }
}
