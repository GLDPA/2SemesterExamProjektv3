using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SommerhusProjektWebService
{
    public partial class Customer
    {
        [StringLength(100)]
        public string Name { get; set; }

        public int Age { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Key]
        public int PhoneNumber { get; set; }

        public int CardNumber { get; set; }

        public int CVC { get; set; }

        public int ExpirationMonth { get; set; }

        public int ExpirationYear { get; set; }
    }
}