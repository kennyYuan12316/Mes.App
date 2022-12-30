namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_PoPackList
    {
        [Key]
        [StringLength(50)]
        public string FC_ID { get; set; }

        [StringLength(50)]
        public string FC_ParentID { get; set; }

        [StringLength(50)]
        public string FC_PrtID { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_Factory { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_PONo { get; set; }

        [StringLength(20)]
        public string FC_PackType { get; set; }

        [StringLength(50)]
        public string FC_Unit { get; set; }

        public decimal? FN_PackNum { get; set; }

        public decimal? FN_UpPackNum { get; set; }

        [StringLength(800)]
        public string FC_BatchCodes { get; set; }

        [StringLength(20)]
        public string FC_PrtFlag { get; set; }

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

        [StringLength(100)]
        public string FC_BoxNo { get; set; }

        public virtual TB_Pck_PrtRec TB_Pck_PrtRec { get; set; }
    }
}
