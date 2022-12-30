namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_EolYeildRate
    {
        [Key]
        public long FN_ID { get; set; }

        [StringLength(150)]
        public string FC_Shape { get; set; }

        [StringLength(50)]
        public string FC_PONo { get; set; }

        [StringLength(50)]
        public string FD_CDate { get; set; }

        [StringLength(50)]
        public string FC_Factory { get; set; }

        [StringLength(50)]
        public string FC_SFCCode { get; set; }

        public int? InputNumb { get; set; }

        public int? outputNumb { get; set; }

        public int? OneNGNumb { get; set; }

        public int? LastNGNumb { get; set; }

        public double? FirstPerRate { get; set; }

        public double? EndPerRate { get; set; }
    }
}
