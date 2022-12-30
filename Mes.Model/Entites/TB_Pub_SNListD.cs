namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Pub_SNListD
    {
        [Key]
        [StringLength(50)]
        public string FC_SNDID { get; set; }

        public int FN_Seq { get; set; }

        [StringLength(50)]
        public string FC_SNID { get; set; }

        [StringLength(200)]
        public string FC_Desc { get; set; }

        [StringLength(200)]
        public string FC_Value { get; set; }

        public int FN_Length { get; set; }

        [Required]
        [StringLength(20)]
        public string FC_Type { get; set; }

        [StringLength(20)]
        public string FC_ValueType { get; set; }

        [StringLength(20)]
        public string FC_CodeType { get; set; }

        [StringLength(1)]
        public string FC_FillChar { get; set; }

        [StringLength(20)]
        public string FC_Upper { get; set; }

        public int? FC_Inc { get; set; }

        [StringLength(20)]
        public string FC_RowFlag { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_CUserID { get; set; }

        public DateTime FD_CDate { get; set; }

        [StringLength(50)]
        public string FC_UUserID { get; set; }

        public DateTime? FD_UDate { get; set; }

        public virtual TB_Pub_SNListM TB_Pub_SNListM { get; set; }
    }
}
