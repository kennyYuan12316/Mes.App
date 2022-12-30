using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Mes.Model.Entites
{
    [Table("Department")]
    public partial class Department
    {
        public int DepartmentID { get; set; }

        [StringLength(50)]
        public string DepartmentName { get; set; }

        [StringLength(10)]
        public string DepartmentCode { get; set; }

        [StringLength(50)]
        public string DepartmentParentID { get; set; }

        public byte? DepartmentStatus { get; set; }

        [StringLength(50)]
        public string DepartmentDesc { get; set; }
    }
}
