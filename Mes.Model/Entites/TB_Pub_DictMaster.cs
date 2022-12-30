namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Pub_DictMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Pub_DictMaster()
        {
            TB_Pub_DictDetail = new HashSet<TB_Pub_DictDetail>();
        }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Pub_DictDetail> TB_Pub_DictDetail { get; set; }
    }
}
