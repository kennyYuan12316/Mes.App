namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_AAData
    {
        [Key]
        public long FN_ID { get; set; }

        [StringLength(50)]
        public string FC_Process { get; set; }

        [StringLength(50)]
        public string FC_Equipment { get; set; }

        [StringLength(150)]
        public string FC_Model { get; set; }

        [StringLength(150)]
        public string FC_SN { get; set; }

        [StringLength(150)]
        public string FC_LotNo { get; set; }

        [StringLength(50)]
        public string FC_TestResult { get; set; }

        [StringLength(50)]
        public string FC_ErrorCode { get; set; }

        public DateTime? FD_TestTime { get; set; }

        public DateTime? FD_CDate { get; set; }

        [StringLength(50)]
        public string FC_JobLocation { get; set; }

        [StringLength(50)]
        public string FC_SonsorIDResult { get; set; }

        [StringLength(100)]
        public string FC_SonsorID { get; set; }

        [StringLength(50)]
        public string FD_SonsorIDTime { get; set; }

        [StringLength(50)]
        public string FC_AA1Result { get; set; }

        [StringLength(50)]
        public string FC_AA1CC { get; set; }

        [StringLength(50)]
        public string FC_AA1UL { get; set; }

        [StringLength(50)]
        public string FC_AA1UR { get; set; }

        [StringLength(50)]
        public string FC_AA1LL { get; set; }

        [StringLength(50)]
        public string FC_AA1LR { get; set; }

        [StringLength(50)]
        public string FC_AA1PLOT_AA { get; set; }

        [StringLength(50)]
        public string FC_AA1ImageCount { get; set; }

        [StringLength(50)]
        public string FC_AA1ImageCountTestTime { get; set; }

        [StringLength(50)]
        public string FC_AA2Result { get; set; }

        [StringLength(50)]
        public string FC_AA2CC { get; set; }

        [StringLength(50)]
        public string FC_AA2UL { get; set; }

        [StringLength(50)]
        public string FC_AA2UR { get; set; }

        [StringLength(50)]
        public string FC_AA2LL { get; set; }

        [StringLength(50)]
        public string FC_AA2LR { get; set; }

        [StringLength(50)]
        public string FC_AA2PLOT_AA { get; set; }

        [StringLength(50)]
        public string FC_AA2ImageCount { get; set; }

        [StringLength(50)]
        public string FC_AA2ImageCountTestTime { get; set; }
    }
}
