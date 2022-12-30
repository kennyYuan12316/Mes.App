namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_RecMatDucWebService
    {
        [Key]
        public int FN_ID { get; set; }

        [Column(TypeName = "text")]
        public string FC_Exception { get; set; }

        [Column(TypeName = "text")]
        public string FC_Json { get; set; }

        public DateTime? FD_CDate { get; set; }
    }
}
