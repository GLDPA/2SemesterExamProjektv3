using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SommerhusProjektWebService
{
    public partial class Opgaver
    {
        [Key]
        public int WorkID { get; set; }

        [StringLength(100)]
        public string SummerhouseName { get; set; }

        public int IDNummer { get; set; }
    }
}