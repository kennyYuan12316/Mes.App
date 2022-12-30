namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_App_System
    {
        [StringLength(40)]
        public string ID { get; set; }

        [StringLength(200)]
        public string APP_NAME { get; set; }

        [StringLength(40)]
        public string APP_ID { get; set; }

        [StringLength(40)]
        public string SECRET { get; set; }

        public DateTime? CREATE_TIME { get; set; }
    }
}
