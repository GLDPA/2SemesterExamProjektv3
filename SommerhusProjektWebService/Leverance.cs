using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SommerhusProjektWebService
{
    public partial class Leverance
    {
        [Key]
        public int OrderNr { get; set; }

        [Key]
        [StringLength(100)]
        public string SummerhouseName { get; set; }

        public int CVR { get; set; }

        public DateTime DeliveryDate { get; set; }

        [StringLength(100)]
        public string DeliveryAddress { get; set; }

        public int Time { get; set; }
    }
}