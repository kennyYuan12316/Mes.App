namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_OvenTemperaturePaperUpload
    {
        [Key]
        public int FN_ID { get; set; }

        [StringLength(50)]
        public string FC_BatchNo { get; set; }

        [StringLength(200)]
        public string FC_FromPatch { get; set; }

        [StringLength(200)]
        public string FC_ToPatch { get; set; }

        [StringLength(50)]
        public string FC_UserID { get; set; }

        [StringLength(50)]
        public string FC_LocalFile { get; set; }

        public DateTime? FD_CDate { get; set; }

        [StringLength(150)]
        public string FC_Shape { get; set; }
    }
}
