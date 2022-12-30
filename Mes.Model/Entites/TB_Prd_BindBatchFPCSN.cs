namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_BindBatchFPCSN
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FN_ID { get; set; }

        [StringLength(4)]
        public string FC_Factory { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string FC_BatchNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(150)]
        public string FC_FPCNo { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(150)]
        public string FC_SN { get; set; }

        [StringLength(50)]
        public string FC_UserID { get; set; }

        [StringLength(4)]
        public string FC_LineID { get; set; }

        public DateTime? FD_CDate { get; set; }

        [StringLength(50)]
        public string FC_PSCode { get; set; }
    }
}
