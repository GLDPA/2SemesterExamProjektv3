using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataTransformation.Implementation;

namespace _2SemesterProjekt.DTO
{
    //using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer : TransformedBase<_2SemesterProjekt.Customer>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            BookingFakturas = new HashSet<BookingFaktura>();
        }

        [Required]
        [StringLength(100)]
        public string Navn { get; set; }

        public int Alder { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TlfNr { get; set; }

        [Column("Kort nummer")]
        public int Kort_nummer { get; set; }

        [Column("CVC nummer")]
        public int CVC_nummer { get; set; }

        public int UdløbsMåned { get; set; }

        public int Udløbår { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingFaktura> BookingFakturas { get; set; }

        public override void SetValuesFromObject(_2SemesterProjekt.Customer obj)
        {
            Key = obj.Key;
            Navn = obj.Name;
            Alder = obj.Age;
            Email = obj.Email;
            TlfNr = obj.PhoneNumber;
            Kort_nummer = obj.CardNumber;
            CVC_nummer = obj.CVC;
            UdløbsMåned = obj.ExpirationMonth;
            Udløbår = obj.ExpirationYear;



        }
    }
}
