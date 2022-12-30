namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_PackValidate
    {
        [Key]
        public int FN_ID { get; set; }

        [StringLength(550)]
        public string FC_InnerID { get; set; }

        [StringLength(550)]
        public string FC_CartonID { get; set; }

        [StringLength(50)]
        public string FC_UserID { get; set; }

        public DateTime? FD_CDate { get; set; }

        [StringLength(250)]
        public string FC_Shape { get; set; }
    }
}
