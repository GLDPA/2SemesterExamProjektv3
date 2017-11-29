using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Implementation;

namespace _2SemesterProjekt.BookingFolder
{
    public class Booking : TransformedBase<Booking>
    {
        public string Name { get; }

        public double TotalPrice { get; set; }

        public string Email { get; }

        public int PhoneNumber { get; }

        public DateTime CheckInDate { get; set; }

        public DateTime CheckInTime { get; set; }

        public DateTime CheckOutDate { get; set; }

        public DateTime CheckOutTime { get; set; }


        public override void SetValuesFromObject(Booking obj)
        {
            CheckInDate = obj.CheckInDate;
            CheckInTime = obj.CheckInTime;
            CheckOutDate = obj.CheckOutDate;
            CheckOutTime = obj.CheckOutTime;
            TotalPrice = obj.TotalPrice;
        }
    }
}
