namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_War_ERPInputBG
    {
        [Key]
        [StringLength(50)]
        public string FC_ID { get; set; }

        [StringLength(50)]
        public string FC_INNo { get; set; }

        [StringLength(50)]
        public string FC_PONo { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_PSID { get; set; }

        public int? FN_TOrder { get; set; }

        [StringLength(50)]
        public string FC_ERPOrder { get; set; }

        public bool? FB_ERPBGFlag { get; set; }

        public int? FN_BGCount { get; set; }

        public DateTime? FD_ERPBGDate { get; set; }

        [StringLength(50)]
        public string FC_ERPBGNo { get; set; }

        [StringLength(50)]
        public string FC_ERPBGCount { get; set; }

        public decimal? FN_BGNums { get; set; }

        [StringLength(300)]
        public string FC_Remarks { get; set; }

        [Required]
        [StringLength(20)]
        public string FC_RowFlag { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_CUserID { get; set; }

        public DateTime FD_CDate { get; set; }

        [StringLength(50)]
        public string FC_UUserID { get; set; }

        public DateTime? FD_UDate { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] FD_Ver { get; set; }

        public virtual TB_War_ERPInput TB_War_ERPInput { get; set; }
    }
}
