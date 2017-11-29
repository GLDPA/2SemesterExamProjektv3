using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SommerhusProjektWebService
{
    public partial class BookingFaktura
    {
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime CheckInDate { get; set; }

        public DateTime CheckOutDate { get; set; }


    }
}