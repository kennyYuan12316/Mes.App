namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_CopyData
    {
        [StringLength(50)]
        public string FC_User { get; set; }

        [StringLength(50)]
        public string FC_PS { get; set; }

        [StringLength(50)]
        public string FC_PNO { get; set; }

        [StringLength(255)]
        public string FC_Version { get; set; }

        [StringLength(50)]
        public string FC_OpeType { get; set; }

        public DateTime? FC_OpeTime { get; set; }

        [Key]
        public int FC_ID { get; set; }

        [StringLength(255)]
        public string FC_PathFile { get; set; }
    }
}
