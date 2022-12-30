using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
namespace Mes.Model.Entites
{

    //[Table(name: "TB_Web_UserOprs")]
    public partial class TB_Web_UserOprs
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string FC_ModuleID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string FC_FuncCode { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string FC_UserID { get; set; }
    }
}
