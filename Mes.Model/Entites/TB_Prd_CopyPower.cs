namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_CopyPower
    {
        [StringLength(4)]
        public string FC_Factory { get; set; }

        [Key]
        [StringLength(50)]
        public string FC_UserName { get; set; }

        public bool? FC_QueryPower { get; set; }

        public bool? FC_UploadPower { get; set; }

        public bool? FC_DownLoadPower { get; set; }

        public bool? FC_DeletePower { get; set; }

        [StringLength(255)]
        public string FC_Remark { get; set; }

        [StringLength(50)]
        public string FC_UDF01 { get; set; }

        public bool? FC_UserPower { get; set; }
    }
}
