using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Implementation;

namespace _2SemesterProjekt.BookingFolder
{
 public  class BookingVm : TransformedBase<Booking>
 {
        public int BookingID { get; set; }

        public string SummerHouseName
        {
            get; set;
        }
        public string CustomerName { get; set; }

        public DateTime CheckInDate { get; set; }

        public DateTime CheckInTime { get; set; }

        public DateTime CheckOutTime { get; set; }

        public DateTime CheckOutDate { get; set; }

        public bool Breakfast { get; set; }

        public DateTime DateOfBooking { get; set; }

        public int PriceForBreakfast { get; set; }

        public int PriceForAnimals { get; set; }

        public override void SetValuesFromObject(Booking obj)
        {
            Key = obj.Key;
            CheckInDate = obj.CheckInDate;
            CheckInTime = obj.CheckInTime;
            CheckOutTime = obj.CheckOutTime;
            CheckOutDate = obj.CheckOutDate;
            Breakfast = obj.Breakfast;
            DateOfBooking = obj.DateOfBooking;
            BookingID = obj.BookingId;
        }
    }
}
