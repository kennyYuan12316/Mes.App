namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_PrintLableData
    {
        [Key]
        public int FN_ID { get; set; }

        [StringLength(50)]
        public string FC_UserID { get; set; }

        [Column(TypeName = "text")]
        public string FC_PrintLableInfo { get; set; }

        public DateTime? FD_CDate { get; set; }

        [Column(TypeName = "text")]
        public string FC_PrintData { get; set; }

        public bool? SendForCustomerFlag { get; set; }

        [StringLength(150)]
        public string FC_PackSN { get; set; }

        public bool? FB_SendFlag { get; set; }
    }
}
