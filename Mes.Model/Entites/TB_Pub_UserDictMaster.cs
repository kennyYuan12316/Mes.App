namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Pub_UserDictMaster
    {
        [Key]
        [StringLength(20)]
        public string FC_CatCode { get; set; }

        [Required]
        [StringLength(60)]
        public string FC_CatName { get; set; }

        [Required]
        [StringLength(20)]
        public string FC_Type { get; set; }

        [StringLength(200)]
        public string FC_Bak { get; set; }

        public int FN_RowFlag { get; set; }

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

        [StringLength(20)]
        public string FC_Parent { get; set; }
    }
}
