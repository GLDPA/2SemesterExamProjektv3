namespace SommerhusProjektWebService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Opgaver")]
    public partial class Opgaver
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ArbejdsId { get; set; }

        [Required]
        [StringLength(100)]
        public string sommerhusNavn { get; set; }

        public int IDNummer { get; set; }

        public virtual KontaktPerson KontaktPerson { get; set; }

        public virtual Sommerhus Sommerhu { get; set; }
    }
}
