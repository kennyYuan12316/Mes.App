namespace Mes.Model.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Prd_SNData
    {
        [Key]
        [StringLength(50)]
        public string FC_ID { get; set; }

        [StringLength(20)]
        public string FC_Factory { get; set; }

        [StringLength(50)]
        public string FC_PSCode { get; set; }

        [StringLength(50)]
        public string FC_PONo { get; set; }

        [StringLength(50)]
        public string FC_BatchNo { get; set; }

        [StringLength(128)]
        public string FC_SN { get; set; }

        public DateTime? FD_CDate { get; set; }

        [StringLength(50)]
        public string FC_CUserID { get; set; }

        [StringLength(255)]
        public string FC_Parm1 { get; set; }

        [StringLength(255)]
        public string FC_Parm2 { get; set; }

        [StringLength(255)]
        public string FC_Parm3 { get; set; }

        [StringLength(255)]
        public string FC_Parm4 { get; set; }

        [StringLength(255)]
        public string FC_Parm5 { get; set; }

        [StringLength(255)]
        public string FC_Parm6 { get; set; }

        [StringLength(255)]
        public string FC_Parm7 { get; set; }

        [StringLength(255)]
        public string FC_Parm8 { get; set; }

        [StringLength(255)]
        public string FC_Parm9 { get; set; }

        [StringLength(255)]
        public string FC_Parm10 { get; set; }

        [StringLength(255)]
        public string FC_Parm11 { get; set; }

        [StringLength(255)]
        public string FC_Parm12 { get; set; }

        [StringLength(255)]
        public string FC_Parm13 { get; set; }

        [StringLength(255)]
        public string FC_Parm14 { get; set; }

        [StringLength(255)]
        public string FC_Parm15 { get; set; }

        [StringLength(255)]
        public string FC_Parm16 { get; set; }

        [StringLength(255)]
        public string FC_Parm17 { get; set; }

        [StringLength(255)]
        public string FC_Parm18 { get; set; }

        [StringLength(255)]
        public string FC_Parm19 { get; set; }

        [StringLength(255)]
        public string FC_Parm20 { get; set; }

        [StringLength(255)]
        public string FC_Parm21 { get; set; }

        [StringLength(255)]
        public string FC_Parm22 { get; set; }

        [StringLength(255)]
        public string FC_Parm23 { get; set; }

        [StringLength(255)]
        public string FC_Parm24 { get; set; }

        [StringLength(255)]
        public string FC_Parm25 { get; set; }

        [StringLength(255)]
        public string FC_Parm26 { get; set; }

        [StringLength(255)]
        public string FC_Parm27 { get; set; }

        [StringLength(255)]
        public string FC_Parm28 { get; set; }

        [StringLength(255)]
        public string FC_Parm29 { get; set; }

        [StringLength(255)]
        public string FC_Parm30 { get; set; }

        [StringLength(255)]
        public string FC_Parm31 { get; set; }

        [StringLength(255)]
        public string FC_Parm32 { get; set; }

        [StringLength(255)]
        public string FC_Parm33 { get; set; }

        [StringLength(255)]
        public string FC_Parm34 { get; set; }

        [StringLength(255)]
        public string FC_Parm35 { get; set; }

        [StringLength(255)]
        public string FC_Parm36 { get; set; }

        [StringLength(255)]
        public string FC_Parm37 { get; set; }

        [StringLength(255)]
        public string FC_Parm38 { get; set; }

        [StringLength(255)]
        public string FC_Parm39 { get; set; }

        [StringLength(255)]
        public string FC_Parm40 { get; set; }

        [StringLength(255)]
        public string FC_Parm41 { get; set; }

        [StringLength(255)]
        public string FC_Parm42 { get; set; }

        [StringLength(255)]
        public string FC_Parm43 { get; set; }

        [StringLength(255)]
        public string FC_Parm44 { get; set; }

        [StringLength(255)]
        public string FC_Parm45 { get; set; }

        [StringLength(255)]
        public string FC_Parm46 { get; set; }

        [StringLength(255)]
        public string FC_Parm47 { get; set; }

        [StringLength(255)]
        public string FC_Parm48 { get; set; }

        [StringLength(255)]
        public string FC_Parm49 { get; set; }

        [StringLength(255)]
        public string FC_Parm50 { get; set; }

        [StringLength(255)]
        public string FC_Parm51 { get; set; }

        [StringLength(255)]
        public string FC_Parm52 { get; set; }

        [StringLength(255)]
        public string FC_Parm53 { get; set; }

        [StringLength(255)]
        public string FC_Parm54 { get; set; }

        [StringLength(255)]
        public string FC_Parm55 { get; set; }

        [StringLength(255)]
        public string FC_Parm56 { get; set; }

        [StringLength(255)]
        public string FC_Parm57 { get; set; }

        [StringLength(255)]
        public string FC_Parm58 { get; set; }

        [StringLength(255)]
        public string FC_Parm59 { get; set; }

        [StringLength(255)]
        public string FC_Parm60 { get; set; }

        [StringLength(255)]
        public string FC_Parm61 { get; set; }

        [StringLength(255)]
        public string FC_Parm62 { get; set; }

        [StringLength(255)]
        public string FC_Parm63 { get; set; }

        [StringLength(255)]
        public string FC_Parm64 { get; set; }

        [StringLength(255)]
        public string FC_Parm65 { get; set; }

        [StringLength(255)]
        public string FC_Parm66 { get; set; }

        [StringLength(255)]
        public string FC_Parm67 { get; set; }

        [StringLength(255)]
        public string FC_Parm68 { get; set; }

        [StringLength(255)]
        public string FC_Parm69 { get; set; }

        [StringLength(255)]
        public string FC_Parm70 { get; set; }

        [StringLength(50)]
        public string FC_Machine { get; set; }

        [Column(TypeName = "text")]
        public string FC_Text1 { get; set; }

        [Column(TypeName = "text")]
        public string FC_Text2 { get; set; }

        [Column(TypeName = "text")]
        public string FC_Text3 { get; set; }

        [Column(TypeName = "text")]
        public string FC_Text4 { get; set; }

        [Column(TypeName = "text")]
        public string FC_Text5 { get; set; }

        [Column(TypeName = "text")]
        public string FC_Text6 { get; set; }
    }
}
