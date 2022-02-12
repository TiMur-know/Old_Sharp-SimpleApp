namespace PRoject.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RAM")]
    public partial class RAM
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

        public int Plank_count { get; set; }

        public int Memory_freq { get; set; }

        [StringLength(50)]
        public string Cold { get; set; }

        [Required]
        [StringLength(50)]
        public string Memory_type { get; set; }

        [StringLength(50)]
        public string Nazn { get; set; }

        public int Throughput { get; set; }

        public int? Voltage { get; set; }

        [Required]
        [StringLength(50)]
        public string Timing_scheme { get; set; }

        public string Additionally { get; set; }

        [MaxLength(1)]
        public byte[] Photo { get; set; }
    }
}
