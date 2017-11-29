namespace SommerhusProjektWebService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sommerhus
    {
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
    }
}
