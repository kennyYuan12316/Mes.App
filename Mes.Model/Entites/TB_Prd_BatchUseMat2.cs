namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_BatchUseMat2
    {
        [Required]
        [StringLength(50)]
        public string FC_BatchNo { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_PONo { get; set; }

        [Required]
        [StringLength(10)]
        public string FC_PSCode { get; set; }

        [Required]
        [StringLength(12)]
        public string FC_WorkCenter { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_MachineNo { get; set; }

        [Required]
        [StringLength(16)]
        public string FC_UseMatMan { get; set; }

        [StringLength(50)]
        public string FC_ERPNo { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_PNo { get; set; }

        [StringLength(100)]
        public string FC_Spec { get; set; }

        [StringLength(200)]
        public string ID { get; set; }

        [Required]
        [StringLength(16)]
        public string FC_UUser { get; set; }

        public DateTime FC_UDate { get; set; }

        [Required]
        [StringLength(10)]
        public string FC_Factory { get; set; }
    }
}
