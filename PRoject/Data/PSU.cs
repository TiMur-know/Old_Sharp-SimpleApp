namespace PRoject.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PSU")]
    public partial class PSU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PSU()
        {
            Corpus = new HashSet<Corpus>();
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

        public int Power { get; set; }

        [Required]
        [StringLength(50)]
        public string Form_factor { get; set; }

        [StringLength(50)]
        public string Shield_tech { get; set; }

        [Required]
        [StringLength(50)]
        public string System_cold { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        [Required]
        [StringLength(50)]
        public string Connector_CPU { get; set; }

        [StringLength(50)]
        public string Connector_Mother { get; set; }

        [StringLength(50)]
        public string Connector_Video { get; set; }

        public int? Connector_Sata { get; set; }

        public int? Connector_Molex { get; set; }

        [Required]
        [StringLength(50)]
        public string Cold { get; set; }

        public int Noise { get; set; }

        [Required]
        [StringLength(20)]
        public string PFC { get; set; }

        public string Additionally { get; set; }

        [MaxLength(1)]
        public byte[] Photo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Corpus> Corpus { get; set; }
    }
}
