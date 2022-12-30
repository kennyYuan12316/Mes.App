namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_CredentialPrinting
    {
        [Key]
        public int FN_ID { get; set; }

        [StringLength(50)]
        public string FC_PoNo { get; set; }

        [StringLength(50)]
        public string FC_MatPNo { get; set; }

        [StringLength(150)]
        public string FC_MatBarcode { get; set; }

        public decimal? FN_PickupNumber { get; set; }

        public decimal? FN_UseNumber { get; set; }

        public decimal? FN_RemainNumber { get; set; }

        public decimal? FN_ThrowingRate { get; set; }

        public decimal? FN_ReturnedNumber { get; set; }

        public decimal? FN_RepairSCrapNum { get; set; }

        public decimal? FN_ProcessSCrapNum { get; set; }

        public decimal? FN_IncomingSCrapNum { get; set; }

        public DateTime? FD_CDate { get; set; }

        [StringLength(50)]
        public string FC_UserID { get; set; }
    }
}
