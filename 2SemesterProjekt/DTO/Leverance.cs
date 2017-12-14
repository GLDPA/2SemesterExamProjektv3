using _2SemesterProjekt.DTO;

namespace ExamProjektWebService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("Leverance")]
    public partial class Leverance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BestillingsNr { get; set; }

        [Required]
        [StringLength(100)]
        public string sommerhusNavn { get; set; }

        public int CVR { get; set; }

        public DateTime LeveringsDato { get; set; }

        [Required]
        [StringLength(100)]
        public string LeveringsAddresse { get; set; }

        public int Tid { get; set; }

        public virtual Leverandør Leverandør { get; set; }

        public virtual SommerhusTable SommerhusTable { get; set; }
    }
}
