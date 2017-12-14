using DataTransformation.Interfaces;

namespace _2SemesterProjekt.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Customer")]
    public partial class Customer : ITransformed<_2SemesterProjekt.Customer>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            BookingFakturas = new HashSet<BookingFaktura>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TlfNr { get; set; }

        [Required]
        [StringLength(100)]
        public string Navn { get; set; }

        public int Alder { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        public int antalBørn { get; set; }

        public int antalDyr { get; set; }

        public int antalPersoner { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingFaktura> BookingFakturas { get; set; }

        public int Key { get; set; }
        public ITransformed<_2SemesterProjekt.Customer> Clone()
        {
            throw new NotImplementedException();
        }

        public void SetValuesFromObject(_2SemesterProjekt.Customer obj)
        {
            throw new NotImplementedException();
        }
    }
}
