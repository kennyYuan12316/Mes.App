namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Pub_WCQCParms
    {
        [Key]
        [StringLength(50)]
        public string FC_ID { get; set; }

        [StringLength(50)]
        public string FC_WKNo { get; set; }

        [StringLength(50)]
        public string FC_CheckNo { get; set; }

        [StringLength(300)]
        public string FC_Remarks { get; set; }

        public virtual TB_Pub_QCParms TB_Pub_QCParms { get; set; }

        public virtual TB_Pub_WorkCenter TB_Pub_WorkCenter { get; set; }
    }
}
