namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Pub_MatCon
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string FC_Factory { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string FC_Code { get; set; }

        [StringLength(200)]
        public string FC_Name { get; set; }

        [StringLength(20)]
        public string FC_Enabled { get; set; }

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
    }
}
