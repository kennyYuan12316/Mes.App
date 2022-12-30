namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Pub_UserDictDetail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string FC_CatCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string FC_ItemValue { get; set; }

        [Required]
        [StringLength(200)]
        public string FC_ItemName { get; set; }

        [StringLength(200)]
        public string FC_ItemValue1 { get; set; }

        [StringLength(200)]
        public string FC_ItemValue2 { get; set; }

        [StringLength(200)]
        public string FC_ItemValue3 { get; set; }

        public int FN_Order { get; set; }

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
    }
}
