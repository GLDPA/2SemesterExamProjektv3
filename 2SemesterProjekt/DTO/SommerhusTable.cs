using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataTransformation.Implementation;

namespace _2SemesterProjekt.DTO
{
    //using System.Data.Entity.Spatial;

    [Table("SommerhusTable")]
    public partial class SommerhusTable : TransformedBase<_2SemesterProjekt.SummerHouse>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SommerhusTable()
        {
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

        public int PrisPrNat { get; set; }

        public int vejNummer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Leverance> Leverances { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Opgaver> Opgavers { get; set; }

        public override void SetValuesFromObject(_2SemesterProjekt.SummerHouse obj)
        {
            sommerhusNavn = obj.NickName;
            postNummer = obj.ZipCode;
            by = obj.City;
            vejNavn = obj.StreetName;
            kommune = obj.Municipality;
            vejNummer = obj.StreetNr;
        }
    }
}
