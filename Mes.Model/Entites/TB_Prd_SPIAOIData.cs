namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_SPIAOIData
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FC_ID { get; set; }

        [StringLength(4)]
        public string FC_Factory { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(150)]
        public string FC_FPCNo { get; set; }

        [StringLength(150)]
        public string FC_SN { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string FC_PositionNo { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string FC_PSCode { get; set; }

        [StringLength(50)]
        public string FC_EquipNo { get; set; }

        public DateTime? TestDate { get; set; }

        [StringLength(50)]
        public string TestResult { get; set; }
    }
}
