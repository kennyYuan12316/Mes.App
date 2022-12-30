namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_TranMac
    {
        [Key]
        [StringLength(50)]
        public string FC_TMacID { get; set; }

        [StringLength(50)]
        public string FC_TranNo { get; set; }

        [StringLength(50)]
        public string FC_MacID { get; set; }

        public decimal? FN_ProcNums { get; set; }

        [StringLength(200)]
        public string FC_ProcMan { get; set; }

        [StringLength(300)]
        public string FC_Remarks { get; set; }

        public virtual TB_Prd_TranInfo TB_Prd_TranInfo { get; set; }
    }
}
