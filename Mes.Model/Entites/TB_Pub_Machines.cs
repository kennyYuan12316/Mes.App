namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Pub_Machines
    {
        [Key]
        [StringLength(50)]
        public string FC_ID { get; set; }

        [StringLength(50)]
        public string FC_WKNo { get; set; }

        [Required]
        [StringLength(300)]
        public string FC_Name { get; set; }

        public decimal? FN_StdCapacity { get; set; }

        public decimal? FN_MaxCapacity { get; set; }

        [StringLength(50)]
        public string FC_Factory { get; set; }

        [StringLength(20)]
        public string FC_Flag { get; set; }

        [StringLength(50)]
        public string FC_ERPNo { get; set; }

        [StringLength(300)]
        public string FC_ERPName { get; set; }

        [StringLength(50)]
        public string FC_ERPFactory { get; set; }

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

        [StringLength(50)]
        public string FC_Type { get; set; }

        [StringLength(50)]
        public string FC_MachineNo { get; set; }

        public bool? FB_Enabled { get; set; }

        [StringLength(50)]
        public string FC_ClassID { get; set; }

        [StringLength(50)]
        public string FC_SoftwareVer { get; set; }

        [StringLength(20)]
        public string FC_PSCode { get; set; }

        [StringLength(50)]
        public string FC_PSName { get; set; }

        [StringLength(50)]
        public string FC_Line { get; set; }

        [StringLength(50)]
        public string FC_Space { get; set; }

        [StringLength(50)]
        public string FC_Space2 { get; set; }

        [StringLength(50)]
        public string FC_Space3 { get; set; }

        [StringLength(50)]
        public string FC_Space4 { get; set; }

        [StringLength(50)]
        public string FC_Space5 { get; set; }

        [StringLength(50)]
        public string FC_Space6 { get; set; }

        public virtual TB_Pub_WorkCenter TB_Pub_WorkCenter { get; set; }
    }
}
