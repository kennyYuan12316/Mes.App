namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LableConfigM")]
    public partial class LableConfigM
    {
        [StringLength(4)]
        public string FC_Factory { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string FC_Guid { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string FC_LabName { get; set; }

        public bool? FB_Enable { get; set; }

        public DateTime? FD_CDate { get; set; }

        [StringLength(50)]
        public string FC_CUser { get; set; }

        [StringLength(50)]
        public string FC_Shape { get; set; }

        [StringLength(50)]
        public string FC_SNRule { get; set; }

        [StringLength(50)]
        public string FC_PackType { get; set; }
    }
}
