namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_QC_OQCCheckNG
    {
        [StringLength(50)]
        public string FC_ID { get; set; }

        [Key]
        [StringLength(50)]
        public string FC_NgID { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_Code { get; set; }

        [Required]
        [StringLength(200)]
        public string FC_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_NgGroup { get; set; }

        public int? FN_Num { get; set; }

        public virtual TB_QC_OQCCheck TB_QC_OQCCheck { get; set; }
    }
}
