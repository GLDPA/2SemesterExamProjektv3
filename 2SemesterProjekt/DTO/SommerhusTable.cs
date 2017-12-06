using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2SemesterProjekt.DTO
{
    //using System.Data.Entity.Spatial;

    [Table("SommerhusTable")]
    public partial class SommerhusTable
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

        public int vejNummer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Leverance> Leverances { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Opgaver> Opgavers { get; set; }
    }
}
