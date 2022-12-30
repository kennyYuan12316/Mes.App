namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_SYS_ConfigDetail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string FC_CoinfigID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string FC_Code { get; set; }

        [StringLength(200)]
        public string FC_Name { get; set; }

        [StringLength(500)]
        public string FC_Value { get; set; }

        [StringLength(500)]
        public string FC_Bak { get; set; }

        public virtual TB_SYS_Config TB_SYS_Config { get; set; }
    }
}
