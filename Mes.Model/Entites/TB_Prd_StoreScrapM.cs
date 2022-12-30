namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_StoreScrapM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Prd_StoreScrapM()
        {
            TB_Prd_StoreScrapD = new HashSet<TB_Prd_StoreScrapD>();
            TB_Prd_StoreScrapSND = new HashSet<TB_Prd_StoreScrapSND>();
        }

        [Key]
        [StringLength(50)]
        public string FC_ScrapNo { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_PONo { get; set; }

        [Required]
        [StringLength(20)]
        public string FC_ScrapType { get; set; }

        public DateTime? FD_SubDate { get; set; }

        public decimal? FN_ScrapNums { get; set; }

        [StringLength(300)]
        public string FC_Remarks { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_Factory { get; set; }

        [StringLength(20)]
        public string FC_Flag { get; set; }

        [Required]
        [StringLength(20)]
        public string FC_RowFlag { get; set; }

        [StringLength(20)]
        public string FC_SubMan { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Prd_StoreScrapD> TB_Prd_StoreScrapD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Prd_StoreScrapSND> TB_Prd_StoreScrapSND { get; set; }
    }
}
