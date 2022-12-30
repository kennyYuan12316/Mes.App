namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_SAPNGCodes
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string CODEGRUPPE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string CODE { get; set; }

        [StringLength(50)]
        public string KURZTEXT { get; set; }
    }
}
