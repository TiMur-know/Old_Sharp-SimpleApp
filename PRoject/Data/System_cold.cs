namespace PRoject.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class System_cold
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public System_cold()
        {
            CPU = new HashSet<CPU>();
        }

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

        public int Size_Vent { get; set; }

        public int? Max_TDP { get; set; }

        public int Noise { get; set; }

        [StringLength(100)]
        public string SVO { get; set; }

        public int? Thickness { get; set; }

        public int? Rotation_speed { get; set; }

        [StringLength(50)]
        public string Socket { get; set; }

        [Required]
        [StringLength(50)]
        public string Naz { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        [Required]
        [StringLength(50)]
        public string Conector { get; set; }

        [StringLength(50)]
        public string Light { get; set; }

        [StringLength(50)]
        public string Bearing { get; set; }

        [StringLength(50)]
        public string Counstruction { get; set; }

        public string Additionally { get; set; }

        [MaxLength(1)]
        public byte[] Photo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPU> CPU { get; set; }
    }
}
