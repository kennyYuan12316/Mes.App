namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_SYS_AutoNo_Detail
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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FN_Seq { get; set; }

        [StringLength(200)]
        public string FC_Desc { get; set; }

        [StringLength(200)]
        public string FC_Value { get; set; }

        public int FN_Length { get; set; }

        public int FN_Type { get; set; }

        public int? FN_ValueType { get; set; }

        [StringLength(1)]
        public string FC_FillChar { get; set; }

        public bool? FN_Upper { get; set; }

        public int? FC_Inc { get; set; }

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
