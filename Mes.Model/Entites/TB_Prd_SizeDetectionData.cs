namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_SizeDetectionData
    {
        [Key]
        public int FN_ID { get; set; }

        [StringLength(20)]
        public string FC_Factory { get; set; }

        [StringLength(50)]
        public string FC_PSCode { get; set; }

        [StringLength(128)]
        public string FC_SN { get; set; }

        public DateTime? FD_CDate { get; set; }

        [StringLength(50)]
        public string FC_CUserID { get; set; }

        [StringLength(50)]
        public string FC_Machine { get; set; }

        [Column(TypeName = "text")]
        public string FC_TestData { get; set; }

        [StringLength(50)]
        public string FC_TestResult { get; set; }
    }
}
