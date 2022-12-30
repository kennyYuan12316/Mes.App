using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Mes.Model.Entites
{
    public partial class TB_Pub_NoticeMessage
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FN_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string FC_Lang { get; set; }

        [Required]
        public string FC_Message { get; set; }

        public int FN_ParaNum { get; set; }

        public DateTime? FD_CDate { get; set; }

        [StringLength(10)]
        public string FC_CUserID { get; set; }

        public DateTime? FD_UDate { get; set; }

        [StringLength(50)]
        public string FC_UUserID { get; set; }
    }
}
