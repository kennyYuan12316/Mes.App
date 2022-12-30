namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_TranPPar
    {
        [Key]
        [StringLength(50)]
        public string FC_TranParID { get; set; }

        [StringLength(50)]
        public string FC_TranNo { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_PSID { get; set; }

        [StringLength(200)]
        public string FC_Value1 { get; set; }

        [StringLength(200)]
        public string FC_Value2 { get; set; }

        public virtual TB_Prd_TranInfo TB_Prd_TranInfo { get; set; }
    }
}
