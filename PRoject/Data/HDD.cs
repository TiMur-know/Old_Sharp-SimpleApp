namespace PRoject.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HDD")]
    public partial class HDD
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Country_Manufact { get; set; }

        [StringLength(50)]
        public string Brand { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(20)]
        public string Sizes { get; set; }

        public int Count { get; set; }

        public decimal Memory_count { get; set; }

        public int Spindle { get; set; }

        public int? Buffer_size { get; set; }

        public decimal Speed_data { get; set; }

        [Required]
        [StringLength(50)]
        public string Connector { get; set; }

        [Required]
        [StringLength(50)]
        public string FormFactor { get; set; }

        [StringLength(50)]
        public string Nazn { get; set; }
        [StringLength(50)]
        public string Type { get; set; }

        public string Additionally { get; set; }

        [MaxLength(1)]
        public byte[] Photo { get; set; }
    }
}
