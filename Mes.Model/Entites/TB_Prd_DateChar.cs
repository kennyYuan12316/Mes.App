namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_DateChar
    {
        public int ID { get; set; }

        public int? FC_Date { get; set; }

        [StringLength(1)]
        public string FC_Char { get; set; }

        [StringLength(50)]
        public string FC_Rule { get; set; }

        [StringLength(50)]
        public string FC_Remark { get; set; }
    }
}
