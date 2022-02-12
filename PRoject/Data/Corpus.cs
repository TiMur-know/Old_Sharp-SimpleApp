namespace PRoject.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Corpus")]
    public partial class Corpus
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

        public int? PSUId { get; set; }

        public int? Vent_Count { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        public int? Section_25 { get; set; }

        public int? Section_Out35 { get; set; }

        public int? Section_In35 { get; set; }

        public int? Section_525 { get; set; }

        [Required]
        [StringLength(50)]
        public string Form_Factors { get; set; }

        [StringLength(50)]
        public string Features { get; set; }

        [StringLength(50)]
        public string Material { get; set; }

        [Required]
        [StringLength(50)]
        public string Install { get; set; }

        public int Max_length_video { get; set; }

        public int Max_heigth_cooler_CPU { get; set; }

        [StringLength(100)]
        public string Conectors { get; set; }

        public string Cold { get; set; }

        public string Additionally { get; set; }

        [MaxLength(1)]
        public byte[] Photo { get; set; }

        public virtual PSU PSU { get; set; }
    }
}
