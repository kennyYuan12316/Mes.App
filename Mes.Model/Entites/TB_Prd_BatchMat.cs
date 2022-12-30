namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_BatchMat
    {
        [Required]
        [StringLength(150)]
        public string FC_MatSN { get; set; }

        [Required]
        [StringLength(150)]
        public string FC_MatName { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_MatNo { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_SupplierNo { get; set; }

        [Required]
        [StringLength(50)]
        public string FC_ProdBatchNo { get; set; }

        [StringLength(50)]
        public string FC_DateCode { get; set; }

        [StringLength(50)]
        public string FC_SendGoodsBatchNo { get; set; }

        [StringLength(50)]
        public string FC_SingleSetNo { get; set; }

        [StringLength(50)]
        public string FC_MatDishNo { get; set; }

        [StringLength(50)]
        public string FC_BottleNo { get; set; }

        [StringLength(50)]
        public string FC_ModelNo { get; set; }

        public int? FC_DishNum { get; set; }

        [StringLength(15)]
        public string FC_SerialNum { get; set; }

        [StringLength(255)]
        public string FC_GetUseFlag { get; set; }

        public int? FC_GetNum { get; set; }

        public int? FC_UseNum { get; set; }

        [StringLength(50)]
        public string FC_SendGoodsBatchNum { get; set; }

        [StringLength(255)]
        public string FC_Remarks { get; set; }

        [StringLength(26)]
        public string FC_BatchNo { get; set; }

        [StringLength(26)]
        public string FC_GetMatNo { get; set; }

        [Required]
        [StringLength(16)]
        public string FC_UUser { get; set; }

        public DateTime? FC_UDate { get; set; }

        [StringLength(5)]
        public string FC_Position { get; set; }

        [StringLength(100)]
        public string ID { get; set; }

        [Required]
        [StringLength(8)]
        public string FC_Factory { get; set; }

        [StringLength(50)]
        public string FC_MachineNo { get; set; }

        [StringLength(255)]
        public string FC_Line { get; set; }

        [StringLength(100)]
        public string FC_InDate { get; set; }

        public int? FC_ExpiryTime { get; set; }

        [StringLength(100)]
        public string FC_BackDate { get; set; }

        public int? FC_BackNum { get; set; }
    }
}
