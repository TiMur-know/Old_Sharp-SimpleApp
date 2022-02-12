namespace PRoject.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SSD")]
    public partial class SSD
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

        public int Memory { get; set; }

        public int Speed_read { get; set; }

        public int Speed_write { get; set; }

        [StringLength(50)]
        public string Cold { get; set; }

        [Required]
        [StringLength(50)]
        public string Connector { get; set; }

        [Required]
        [StringLength(50)]
        public string FormFactor { get; set; }

        [Required]
        [StringLength(50)]
        public string Purpose { get; set; }

        [Required]
        [StringLength(50)]
        public string Type_drive { get; set; }

        [Required]
        [StringLength(50)]
        public string Type_cells { get; set; }

        public string Additionally { get; set; }

        [MaxLength(1)]
        public byte[] Photo { get; set; }
    }
}
