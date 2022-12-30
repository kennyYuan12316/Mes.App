namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_StoreRemoveD
    {
        [Key]
        [StringLength(50)]
        public string FC_StoreRemoveDNo { get; set; }

        [StringLength(50)]
        public string FC_ID { get; set; }

        [StringLength(50)]
        public string FC_StoreRemoveNo { get; set; }

        [StringLength(50)]
        public string FC_BatchNo { get; set; }

        public decimal? FN_RemoveNum { get; set; }

        [StringLength(300)]
        public string FC_Remarks { get; set; }

        public virtual TB_Prd_StoreRemoveM TB_Prd_StoreRemoveM { get; set; }
    }
}
