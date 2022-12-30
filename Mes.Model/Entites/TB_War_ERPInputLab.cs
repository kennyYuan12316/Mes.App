namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_War_ERPInputLab
    {
        [Key]
        [StringLength(50)]
        public string FC_LID { get; set; }

        [StringLength(50)]
        public string FC_INNo { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_CUserID { get; set; }

        public DateTime FD_CDate { get; set; }

        public decimal? FN_PackNum { get; set; }

        public virtual TB_War_ERPInput TB_War_ERPInput { get; set; }
    }
}
