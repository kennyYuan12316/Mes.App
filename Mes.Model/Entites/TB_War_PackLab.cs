namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_War_PackLab
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_War_PackLab()
        {
            TB_War_PackB = new HashSet<TB_War_PackB>();
        }

        [Key]
        [StringLength(50)]
        public string FC_LowLabID { get; set; }

        [StringLength(50)]
        public string FC_LowPID { get; set; }

        [StringLength(150)]
        public string FC_BoxID { get; set; }

        [StringLength(20)]
        public string FC_Flag { get; set; }

        public decimal? FC_PackNums { get; set; }

        [StringLength(50)]
        public string FC_CUserID { get; set; }

        public DateTime? FD_CDate { get; set; }

        public decimal? FN_Weight { get; set; }

        [StringLength(50)]
        public string FC_WeiUnit { get; set; }

        [StringLength(50)]
        public string FC_ParentID { get; set; }

        [StringLength(20)]
        public string FC_ChkFlag { get; set; }

        [StringLength(50)]
        public string FD_ChkMan { get; set; }

        public DateTime? FD_ChkDate { get; set; }

        [StringLength(50)]
        public string FC_ChkID { get; set; }

        [StringLength(300)]
        public string FC_ChkRemark { get; set; }

        public virtual TB_War_ChkLab TB_War_ChkLab { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_War_PackB> TB_War_PackB { get; set; }

        public virtual TB_War_PackM TB_War_PackM { get; set; }
    }
}
