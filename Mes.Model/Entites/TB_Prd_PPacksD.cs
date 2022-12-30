namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_PPacksD
    {
        [Key]
        [StringLength(50)]
        public string FC_PackID { get; set; }

        [StringLength(50)]
        public string FC_PID { get; set; }

        public int FN_Order { get; set; }

        [StringLength(20)]
        public string FC_PackType { get; set; }

        public decimal? FN_PackNum { get; set; }

        public decimal? FN_UpPackNum { get; set; }

        [StringLength(500)]
        public string FC_FilePath { get; set; }

        [StringLength(50)]
        public string FC_Unit { get; set; }

        [StringLength(500)]
        public string FC_Ext1 { get; set; }

        [StringLength(250)]
        public string FC_Ext2 { get; set; }

        [StringLength(500)]
        public string FC_Ext3 { get; set; }

        [StringLength(500)]
        public string FC_Ext4 { get; set; }

        [StringLength(500)]
        public string FC_Ext5 { get; set; }

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

        public virtual TB_Prd_PPacks TB_Prd_PPacks { get; set; }
    }
}
