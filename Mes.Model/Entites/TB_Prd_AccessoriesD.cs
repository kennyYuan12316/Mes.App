namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_AccessoriesD
    {
        [Required]
        [StringLength(50)]
        public string FC_AccessoriesNo { get; set; }

        [Required]
        [StringLength(250)]
        public string FC_AccessoriesBarCode { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_AccessoriesName { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_AccessoriesStatus { get; set; }

        public DateTime FC_CreatDate { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_CreatPeople { get; set; }

        [StringLength(150)]
        public string FC_Remark { get; set; }

        [Required]
        [StringLength(4)]
        public string FC_Factory { get; set; }

        [Key]
        [StringLength(100)]
        public string FC_ID { get; set; }

        public int? FC_RemainCount { get; set; }
    }
}
