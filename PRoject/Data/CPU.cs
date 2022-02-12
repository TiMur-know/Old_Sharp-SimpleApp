namespace PRoject.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CPU")]
    public partial class CPU
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
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

        public int Count_core { get; set; }

        public int Count_threare { get; set; }

        public int Clock_freq { get; set; }

        public int? Max_Clock_freq { get; set; }

        [StringLength(50)]
        public string Type_memory { get; set; }

        [Required]
        [StringLength(50)]
        public string Family_CPU { get; set; }

        [Required]
        [StringLength(50)]
        public string Socket { get; set; }

        [Required]
        [StringLength(50)]
        public string CPU_gen { get; set; }

        [Required]
        [StringLength(50)]
        public string Naz { get; set; }

        [Required]
        [StringLength(50)]
        public string Type_box { get; set; }

        [Required]
        [StringLength(50)]
        public string Multipler { get; set; }

        public bool Vent { get; set; }

        public int? ColdId { get; set; }

        [StringLength(30)]
        public string Cash { get; set; }

        [StringLength(50)]
        public string InVideo { get; set; }

        public int? Power_TDP { get; set; }

        public string Additionally { get; set; }

        [MaxLength(1)]
        public byte[] Photo { get; set; }

        public virtual System_cold System_cold { get; set; }
    }
}
