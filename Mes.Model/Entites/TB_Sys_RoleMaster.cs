using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
namespace Mes.Model.Entites
{
    public partial class TB_Sys_RoleMaster
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FN_ID { get; set; }

        [Key]
        [StringLength(50)]
        public string FC_RoleID { get; set; }

        [StringLength(50)]
        public string FC_RoleName { get; set; }

        [StringLength(50)]
        public string FC_CUser { get; set; }

        public DateTime FD_CDate { get; set; }

        [StringLength(50)]
        public string FC_UUser { get; set; }

        public DateTime FD_UDate { get; set; }
    }
}
