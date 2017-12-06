using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2SemesterProjekt.DTO
{
    //using System.Data.Entity.Spatial;

    public partial class Leverandør
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Leverandør()
        {
            Leverances = new HashSet<Leverance>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CVR { get; set; }

        [Required]
        [StringLength(100)]
        public string Navn { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        public int TlfNr { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Leverance> Leverances { get; set; }
    }
}
