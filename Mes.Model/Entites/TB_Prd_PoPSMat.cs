namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_PoPSMat
    {
        [Key]
        public int FN_ID { get; set; }

        [StringLength(50)]
        public string FC_PONO { get; set; }

        [StringLength(50)]
        public string FC_PSName { get; set; }

        [StringLength(50)]
        public string FC_PSCode { get; set; }

        [StringLength(250)]
        public string FC_MatNo { get; set; }

        [StringLength(250)]
        public string FC_MatName { get; set; }

        public DateTime? FC_CDate { get; set; }

        [StringLength(50)]
        public string FC_CUser { get; set; }

        public int? FC_MatNumber { get; set; }

        [StringLength(10)]
        public string FC_Factory { get; set; }
    }
}
