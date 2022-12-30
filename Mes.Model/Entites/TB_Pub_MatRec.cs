namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Pub_MatRec
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(200)]
        public string FC_Prefix { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string FC_SNID { get; set; }

        public int? FC_Current { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_CUserID { get; set; }

        public DateTime FD_CDate { get; set; }
    }
}
