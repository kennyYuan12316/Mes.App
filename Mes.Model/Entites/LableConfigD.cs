namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LableConfigD")]
    public partial class LableConfigD
    {
        [Required]
        [StringLength(100)]
        public string FC_Guid { get; set; }

        [StringLength(50)]
        public string FC_LabName { get; set; }

        [StringLength(50)]
        public string FC_LabKey { get; set; }

        [StringLength(50)]
        public string FC_LabValue { get; set; }

        [StringLength(50)]
        public string FC_LabType { get; set; }

        [StringLength(50)]
        public string FC_LableDes { get; set; }

        [StringLength(50)]
        public string FC_CUser { get; set; }

        public DateTime? FD_CDate { get; set; }

        [StringLength(50)]
        public string FC_UUser { get; set; }

        public DateTime? FD_UDate { get; set; }

        public int? FC_Seq { get; set; }

        [StringLength(50)]
        public string FC_Split { get; set; }

        [StringLength(50)]
        public string FC_Shape { get; set; }

        [StringLength(50)]
        public string FC_SNRule { get; set; }

        [StringLength(50)]
        public string FC_PackType { get; set; }

        [StringLength(50)]
        public string FC_TxtType { get; set; }

        [StringLength(50)]
        public string FC_TxtName { get; set; }

        [Key]
        public int FN_ID { get; set; }
    }
}
