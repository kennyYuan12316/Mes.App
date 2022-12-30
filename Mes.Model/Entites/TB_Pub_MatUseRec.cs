namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Pub_MatUseRec
    {
        [Key]
        [StringLength(50)]
        public string FC_UseID { get; set; }

        [StringLength(50)]
        public string FC_SNID { get; set; }

        public decimal? FN_GetNum { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_CUserID { get; set; }

        public DateTime FD_CDate { get; set; }
    }
}
