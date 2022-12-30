namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_AccessoriesM
    {
        [Required]
        [StringLength(150)]
        public string FC_AccessoriesName { get; set; }

        [Key]
        [StringLength(50)]
        public string FC_AccessoriesNo { get; set; }

        [Required]
        [StringLength(150)]
        public string FC_AccessoriesType { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_brand { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_Spec { get; set; }

        public int? FC_ActiveTime { get; set; }

        public int? FC_ActiveDegrees { get; set; }

        public DateTime FC_CreatDate { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_CreatPeople { get; set; }

        [StringLength(150)]
        public string FC_BackCount { get; set; }

        [StringLength(4)]
        public string FC_Factory { get; set; }

        public int? FC_ThawTime { get; set; }

        [StringLength(50)]
        public string FC_AccessoriesRule { get; set; }

        [StringLength(50)]
        public string FC_AccessoriesPrdType { get; set; }
    }
}
