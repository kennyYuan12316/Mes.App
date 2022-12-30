namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_TranSNNGInfo
    {
        [Key]
        [StringLength(50)]
        public string FC_SNNGNO { get; set; }

        [StringLength(20)]
        public string FC_PONO { get; set; }

        [StringLength(20)]
        public string FC_Batch { get; set; }

        [StringLength(50)]
        public string FC_NGNO { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_SN { get; set; }

        [StringLength(10)]
        public string FC_PSCode { get; set; }

        [StringLength(10)]
        public string FC_PSOrder { get; set; }

        [StringLength(10)]
        public string FC_Factory { get; set; }
    }
}
