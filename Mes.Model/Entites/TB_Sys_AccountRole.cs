using System;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
namespace Mes.Model.Entites
{
    public partial class TB_Sys_AccountRole
    {
        [Key]
        public int FN_ID { get; set; }

        [StringLength(50)]
        public string FC_RoleId { get; set; }

        [StringLength(50)]
        public string FC_AcctId { get; set; }

        public DateTime FD_CDate { get; set; }

        [StringLength(50)]
        public string FC_CUser { get; set; }
    }
}
