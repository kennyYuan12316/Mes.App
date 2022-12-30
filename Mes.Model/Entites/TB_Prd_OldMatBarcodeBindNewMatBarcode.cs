namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_OldMatBarcodeBindNewMatBarcode
    {
        [Key]
        public int FN_ID { get; set; }

        [StringLength(50)]
        public string FC_OldPoNo { get; set; }

        [StringLength(150)]
        public string FC_OldMatBarcode { get; set; }

        [StringLength(50)]
        public string FC_NewPoNo { get; set; }

        [StringLength(150)]
        public string FC_NewMatBarcode { get; set; }

        [StringLength(50)]
        public string FC_UserID { get; set; }

        public DateTime? FD_CDate { get; set; }
    }
}
