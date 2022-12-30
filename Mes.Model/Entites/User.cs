using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Mes.Model.Entites
{
    [Table("User")]
    public partial class User
    {
        public int UserID { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(20)]
        public string UserCode { get; set; }

        [StringLength(50)]
        public string UserPhone { get; set; }

        [StringLength(50)]
        public string UserEmail { get; set; }

        [StringLength(255)]
        public string UserImage { get; set; }

        public byte? UserGender { get; set; }

        public byte? UserStatus { get; set; }

        [StringLength(10)]
        public string UserPassword { get; set; }

        [StringLength(10)]
        public string DepartmentCode { get; set; }
    }
}
