using DataTransformation.Implementation;
using DataTransformation.Interfaces;

namespace _2SemesterProjekt.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("SommerhusTable")]
    public partial class SommerhusTable : TransformedBase<SummerHouse>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SommerhusTable()
        {
            BookingFakturas = new HashSet<BookingFaktura>();
            Leverances = new HashSet<Leverance>();
            Opgavers = new HashSet<Opgaver>();
        }

        [Key]
        [StringLength(100)]
        public string sommerhusNavn { get; set; }

        public int postNummer { get; set; }

        [Required]
        [StringLength(100)]
        public string by { get; set; }

        [Required]
        [StringLength(100)]
        public string vejNavn { get; set; }

        [Required]
        [StringLength(100)]
        public string kommune { get; set; }

        public int vejNummer { get; set; }

        public int prisPrNat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingFaktura> BookingFakturas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Leverance> Leverances { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Opgaver> Opgavers { get; set; }

        //public override void SetValuesFromObject(SummerHouse obj)
        //{
        //    sommerhusNavn = obj.NickName;
        //    postNummer = obj.ZipCode;
        //    by = obj.City;
        //    vejNavn = obj.StreetName;
        //    kommune = obj.Municipality;
        //    vejNummer = obj.StreetNr;
        //    prisPrNat = obj.PricePrNight;

        //    return new SummerHouse();
        //}

        public override void SetValuesFromObject(SummerHouse obj)
        {
            sommerhusNavn = obj.NickName;
            vejNavn = obj.StreetName;
            vejNummer = obj.StreetNr;
            by = obj.City;
            kommune = obj.Municipality;
            postNummer = obj.ZipCode;
            prisPrNat = obj.PricePrNight;


        }
    }
}
