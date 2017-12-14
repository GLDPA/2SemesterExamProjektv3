using _2SemesterProjekt.DTO;

namespace ExamProjektWebService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("BookingFaktura")]
    public partial class BookingFaktura
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int bookingNummer { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int fakturaNummer { get; set; }

        [Column("Total pris")]
        public int Total_pris { get; set; }

        public DateTime checkIndDato { get; set; }

        public DateTime checkUdDato { get; set; }

        public DateTime datoForBooking { get; set; }

        public DateTime datoForFaktura { get; set; }

        public bool morgenmad { get; set; }

        [Column("Tlf Nr")]
        public int Tlf_Nr { get; set; }

        [Required]
        [StringLength(100)]
        public string sommerhusNavn { get; set; }

        public virtual SommerhusTable SommerhusTable { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
