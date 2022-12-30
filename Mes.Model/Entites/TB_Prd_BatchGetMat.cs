namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_BatchGetMat
    {
        [Key]
        [StringLength(50)]
        public string FC_GetMatNo { get; set; }

        [Required]
        [StringLength(16)]
        public string FC_GetMatMan { get; set; }

        [Required]
        [StringLength(16)]
        public string FC_OutputStorage { get; set; }

        [Required]
        [StringLength(16)]
        public string FC_InputStorage { get; set; }

        [Required]
        [StringLength(4)]
        public string FC_GetMatFlag { get; set; }

        [Required]
        [StringLength(16)]
        public string FC_UUser { get; set; }

        public DateTime FC_UDate { get; set; }

        [StringLength(255)]
        public string FC_Remarks { get; set; }

        [Required]
        [StringLength(8)]
        public string FC_Factory { get; set; }
    }
}
