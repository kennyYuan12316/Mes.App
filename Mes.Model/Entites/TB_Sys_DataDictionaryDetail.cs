using Mes.Model.CommModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Mes.Model.Entites
{
    public partial class TB_Sys_DataDictionaryDetail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(150)]
        public string FC_DicCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(150)]
        [Mapper("pk")]
        public string FC_PK { get; set; }

        [StringLength(150)]
        [Mapper("pn")]
        public string FC_PN { get; set; }

        [Mapper("v1")]
        [StringLength(250)]
        public string FC_V1 { get; set; }

        [Mapper("v2")]
        [StringLength(250)]
        public string FC_V2 { get; set; }

        [Mapper("v3")]
        [StringLength(250)]
        public string FC_V3 { get; set; }

        [Mapper("v4")]
        [StringLength(250)]
        public string FC_V4 { get; set; }

        [Mapper("v5")]
        [StringLength(250)]
        public string FC_V5 { get; set; }

        [Mapper("v6")]
        [StringLength(250)]
        public string FC_V6 { get; set; }

        [Mapper("createDate")]
        public DateTime FD_CDate { get; set; }

        [Mapper("createUserId")]
        [StringLength(50)]
        public string FC_CUser { get; set; }

        [Mapper("sort")]
        public int FN_Sort { get; set; }
    }
}
