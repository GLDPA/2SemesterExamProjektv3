using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SommerhusProjektWebService
{
    public partial class KontaktPerson
    {
        [Key]
        public int IDNumber { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public int PhoneNumber { get; set; }
    }
}