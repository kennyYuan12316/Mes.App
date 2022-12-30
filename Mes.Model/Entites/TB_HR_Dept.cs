namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_HR_Dept
    {
        [Key]
        [StringLength(50)]
        public string FC_DeptID { get; set; }

        [StringLength(200)]
        public string FC_GovName { get; set; }

        public int? FC_AreaID { get; set; }

        [StringLength(50)]
        public string FN_Level { get; set; }

        [StringLength(50)]
        public string FC_Tel { get; set; }

        [StringLength(50)]
        public string FC_Zip { get; set; }

        [StringLength(50)]
        public string FC_Mobel { get; set; }

        [StringLength(300)]
        public string FC_Addr { get; set; }

        [StringLength(200)]
        public string FC_EMail { get; set; }

        [StringLength(50)]
        public string FC_ParentID { get; set; }

        public bool? FB_Enabled { get; set; }

        [StringLength(200)]
        public string FC_Description { get; set; }

        public int? FN_RowFlag { get; set; }

        [Required]
        [StringLength(20)]
        public string FC_CUserID { get; set; }

        public DateTime FD_CDate { get; set; }

        [StringLength(20)]
        public string FC_UUserID { get; set; }

        public DateTime? FD_UDate { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] FD_Version { get; set; }

        [StringLength(50)]
        public string FC_DeptType { get; set; }

        [StringLength(50)]
        public string FC_ERPNo { get; set; }

        [StringLength(50)]
        public string FC_Factory { get; set; }

        [StringLength(50)]
        public string FC_NGGroup { get; set; }

        [StringLength(20)]
        public string FC_StockFlag { get; set; }
    }
}
