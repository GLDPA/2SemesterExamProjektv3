using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Web;

namespace SommerhusProjektWebService
{
    public partial class BookingFaktura
    {
        [StringLength(100)]
        public string CustomerName { get; set; }

        [Key]
        [StringLength(100)]
        public string Email { get; set; }

        [Key]
        public string PhoneNumber { get; set; }

        public int NumberOfAnimals { get; set; }

        public int NumberOfChildren { get; set; }

        public double Price { get; set; }

        public int FakturaNr { get; set; }


        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime CheckInDate { get; set; }

        public DateTime CheckOutDate { get; set; }


    }
}