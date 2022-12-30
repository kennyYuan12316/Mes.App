namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Pub_Storage
    {
        [Key]
        [StringLength(50)]
        public string FC_StorageNo { get; set; }

        [StringLength(50)]
        public string FC_WarNo { get; set; }

        [Required]
        [StringLength(200)]
        public string FC_Name { get; set; }
    }
}
