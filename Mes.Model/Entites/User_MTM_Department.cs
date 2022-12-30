using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Mes.Model.Entites
{
    public partial class User_MTM_Department
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string UserCode { get; set; }

        [StringLength(10)]
        public string DepartmentCode { get; set; }
    }
}
