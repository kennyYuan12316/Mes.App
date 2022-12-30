namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Pub_MatListM
    {
        [Key]
        [StringLength(50)]
        public string FC_SNID { get; set; }

        [StringLength(100)]
        public string FC_SNName { get; set; }

        [StringLength(20)]
        public string FC_SNType { get; set; }

        [StringLength(1000)]
        public string FC_SQL { get; set; }

        [StringLength(20)]
        public string FC_Enable { get; set; }

        [StringLength(200)]
        public string FC_Bak { get; set; }

        [StringLength(20)]
        public string FC_RowFlag { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_CUserID { get; set; }

        public DateTime FD_CDate { get; set; }

        [StringLength(50)]
        public string FC_UUserID { get; set; }

        public DateTime? FD_UDate { get; set; }
    }
}
