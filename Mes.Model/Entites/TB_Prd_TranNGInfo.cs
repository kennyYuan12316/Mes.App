namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_TranNGInfo
    {
        [Key]
        [StringLength(50)]
        public string FC_NGNo { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_TranNo { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_CodeNo { get; set; }

        public decimal? FN_Nums { get; set; }

        [StringLength(50)]
        public string FC_PSCode { get; set; }

        [StringLength(300)]
        public string FC_Remarks { get; set; }

        [StringLength(50)]
        public string FC_ChkMan { get; set; }

        [StringLength(50)]
        public string FC_Factory { get; set; }

        [StringLength(50)]
        public string FC_NGGroup { get; set; }

        public virtual TB_Prd_TranInfo TB_Prd_TranInfo { get; set; }
    }
}
