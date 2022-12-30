namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Pub_ProcSPs
    {
        [Key]
        [StringLength(50)]
        public string FC_PSID { get; set; }

        [StringLength(50)]
        public string FC_PSNo { get; set; }

        [StringLength(100)]
        public string FC_Name { get; set; }

        [StringLength(20)]
        public string FC_MustCon { get; set; }

        [StringLength(300)]
        public string FC_Remarks { get; set; }

        public virtual TB_Pub_ProcSetup TB_Pub_ProcSetup { get; set; }
    }
}
