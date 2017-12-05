using _2SemesterProjekt;

namespace SommerhusProjektWebService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("BookingFaktura")]
    public partial class BookingFaktura
    {
        [Key]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string KundeNavn { get; set; }

        [Column("Tlf Nr")]
        public int? Tlf_Nr { get; set; }

        [Column("Antal Dyr")]
        public int Antal_Dyr { get; set; }

        [Column("Antal Børn")]
        public int Antal_Børn { get; set; }

        [Column("Total pris")]
        public int Total_pris { get; set; }

        [Column("Faktura Nr")]
        public int Faktura_Nr { get; set; }

        [Column("Start dato")]
        public DateTime Start_dato { get; set; }

        [Column("Slut dato")]
        public DateTime Slut_dato { get; set; }

        [Column("CheckIn dato")]
        public DateTime CheckIn_dato { get; set; }

        [Column("Check-Ud dato")]
        public DateTime Check_Ud_dato { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
