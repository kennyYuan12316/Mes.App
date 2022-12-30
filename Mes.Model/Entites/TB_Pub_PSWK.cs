namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Pub_PSWK
    {
        [Key]
        [StringLength(50)]
        public string FC_DID { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_PSNo { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_WKNo { get; set; }

        public virtual TB_Pub_ProcSetup TB_Pub_ProcSetup { get; set; }

        public virtual TB_Pub_WorkCenter TB_Pub_WorkCenter { get; set; }
    }
}
