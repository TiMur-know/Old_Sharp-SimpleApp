namespace PRoject.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Videocard")]
    public partial class Videocard
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

        public int Memory_Count { get; set; }

        [StringLength(50)]
        public string Max_rash { get; set; }

        public int Min_power_PSU { get; set; }

        public int Memory_Freq { get; set; }

        public int Core_Freq { get; set; }

        [Required]
        [StringLength(50)]
        public string Family { get; set; }

        [Required]
        [StringLength(50)]
        public string Manufacture { get; set; }

        [Required]
        [StringLength(50)]
        public string Cheap { get; set; }

        [Required]
        [StringLength(50)]
        public string Conector { get; set; }

        public int Memory_bus { get; set; }

        [Required]
        [StringLength(50)]
        public string Memory_type { get; set; }

        [Required]
        [StringLength(50)]
        public string Interface { get; set; }

        [Required]
        [StringLength(50)]
        public string FormFactor { get; set; }

        [StringLength(50)]
        public string Cold { get; set; }

        [StringLength(50)]
        public string Advice_power { get; set; }

        [Required]
        [StringLength(50)]
        public string Cold_Type { get; set; }

        public string Additionally { get; set; }

        [MaxLength(1)]
        public byte[] Photo { get; set; }
    }
}
