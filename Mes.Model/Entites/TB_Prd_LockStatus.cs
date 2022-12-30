namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_LockStatus
    {
        [StringLength(4)]
        public string FC_Factory { get; set; }

        [Key]
        [StringLength(50)]
        public string FC_BatchNo { get; set; }

        public bool? FC_Status { get; set; }

        [StringLength(50)]
        public string FC_UDF01 { get; set; }

        [StringLength(50)]
        public string FC_UDF02 { get; set; }

        public int? FC_UDF51 { get; set; }

        public int? FC_UDF52 { get; set; }

        public bool? FC_UDF61 { get; set; }

        public bool? FC_UDF62 { get; set; }
    }
}
