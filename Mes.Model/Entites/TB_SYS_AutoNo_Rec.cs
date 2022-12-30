namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_SYS_AutoNo_Rec
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string FC_TableName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string FC_ColumnName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string FC_Prefix { get; set; }

        public int? FC_Current { get; set; }

        public int? FN_RowFlag { get; set; }

        [Required]
        [StringLength(20)]
        public string FC_CUserID { get; set; }

        public DateTime FD_CDate { get; set; }

        [StringLength(20)]
        public string FC_UUserID { get; set; }

        public DateTime? FD_UDate { get; set; }

        public virtual TB_SYS_AutoNo_Master TB_SYS_AutoNo_Master { get; set; }
    }
}
