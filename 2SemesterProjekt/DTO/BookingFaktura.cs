using DataTransformation.Interfaces;
using _2SemesterProjekt.BookingFolder;

namespace _2SemesterProjekt.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("BookingFaktura")]
    public partial class BookingFaktura :ITransformed<Booking>
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
        public double Total_pris { get; set; }

        public DateTimeOffset checkIndDato { get; set; }

        public DateTimeOffset checkUdDato { get; set; }

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
        public int Key { get; set; }
        public ITransformed<Booking> Clone()
        {
            return new Booking();
        }

        public void SetValuesFromObject(Booking obj)
        {
            bookingNummer = obj.BookingID;
            fakturaNummer = obj.InvoiceNumber;
            datoForBooking = obj.DateOfBooking;
            datoForFaktura = obj.DateOfInvoice;
            checkIndDato = obj.CheckInDate;
            checkUdDato = obj.CheckOutDate;
            Total_pris = obj.TotalPrice;
            morgenmad = obj.Breakfast;
        }
    }
}
