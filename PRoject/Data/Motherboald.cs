namespace PRoject.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Motherboald")]
    public partial class Motherboald
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Country_Manufact { get; set; }

        [StringLength(50)]
        public string Brand { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(20)]
        public string Sizes { get; set; }

        public int Count { get; set; }

        [StringLength(50)]
        public string Form_factor { get; set; }

        [Required]
        [StringLength(50)]
        public string Socket { get; set; }

        [Required]
        [StringLength(50)]
        public string Chipset { get; set; }

        [Required]
        [StringLength(100)]
        public string Support_Memory { get; set; }

        public int? M2 { get; set; }

        [StringLength(60)]
        public string Video { get; set; }

        [StringLength(50)]
        public string Wifi { get; set; }

        public decimal? Max_RAM { get; set; }

        [StringLength(50)]
        public string Help_CPU { get; set; }

        [StringLength(50)]
        public string Nazn { get; set; }

        [Required]
        [StringLength(100)]
        public string Connectors { get; set; }

        public int? Memory_cells { get; set; }

        [Required]
        [StringLength(100)]
        public string PSI { get; set; }

        public int Max_memory_chart { get; set; }

        [Required]
        [StringLength(50)]
        public string Sata { get; set; }

        [Required]
        [StringLength(50)]
        public string Net { get; set; }

        [Required]
        [StringLength(100)]
        public string Vneshni { get; set; }

        public string Additionally { get; set; }

        [MaxLength(1)]
        public byte[] Photo { get; set; }
    }
}
