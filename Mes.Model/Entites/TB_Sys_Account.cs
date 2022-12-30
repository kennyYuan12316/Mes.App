using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Mes.Model.Entites
{
    public partial class TB_Sys_Account
    {
        [Key]
        public int FN_ID { get; set; }

        [StringLength(50)]
        public string FC_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_AcctId { get; set; }

        [StringLength(50)]
        public string FC_Phone { get; set; }

        [StringLength(50)]
        public string FC_Email { get; set; }

        [StringLength(250)]
        public string FC_Image { get; set; }

        public bool FB_Gender { get; set; }

        public bool FB_Status { get; set; }

        [StringLength(50)]
        public string FC_Password { get; set; }

        [StringLength(50)]
        public string FC_DeptId { get; set; }

        public DateTime FD_CDate { get; set; }

        public DateTime FD_UDate { get; set; }

        [StringLength(50)]
        public string FC_CUser { get; set; }

        [StringLength(50)]
        public string FC_UUser { get; set; }
    }
}
