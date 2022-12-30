namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_MatClose
    {
        [Key]
        public int FN_ID { get; set; }

        [StringLength(50)]
        public string FC_ERPNo { get; set; }

        [StringLength(50)]
        public string FC_PoNo { get; set; }

        public bool? FC_MatCloseFlag { get; set; }

        public DateTime? FD_DateTime { get; set; }

        [StringLength(50)]
        public string FC_UserID { get; set; }
    }
}
