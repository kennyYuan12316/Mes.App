using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Mes.Model.Entites
{
    public partial class TB_Sys_Department
    {
        [Key]
        public int FN_ID { get; set; }

        [StringLength(50)]
        public string FC_DeptName { get; set; }

        [StringLength(10)]
        public string FC_DeptId { get; set; }

        [StringLength(50)]
        public string FC_ParentID { get; set; }

        public bool FB_Status { get; set; }

        [StringLength(50)]
        public string FC_Remark { get; set; }

        public DateTime FD_CDate { get; set; }

        public DateTime FD_UDate { get; set; }

        [StringLength(50)]
        public string FC_CUser { get; set; }

        [StringLength(50)]
        public string FC_UUser { get; set; }
    }
}
