using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataTransformation.Implementation;
using _2SemesterProjekt.BookingFolder;

namespace _2SemesterProjekt.DTO
{
    //using System.Data.Entity.Spatial;

    [Table("BookingFaktura")]
    public partial class BookingFaktura : TransformedBase<_2SemesterProjekt.BookingFolder.Booking>
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
        public DateTimeOffset Start_dato { get; set; }

        [Column("Slut dato")]
        public DateTimeOffset Slut_dato { get; set; }

        [Column("CheckIn dato")]
        public DateTimeOffset CheckIn_dato { get; set; }

        [Column("Check-Ud dato")]
        public DateTimeOffset Check_Ud_dato { get; set; }

        public virtual Customer Customer { get; set; }
        public override void SetValuesFromObject(Booking obj)
        {
            Start_dato = obj.CheckInDate;
            Slut_dato = obj.CheckOutDate;


        }
    }
}
