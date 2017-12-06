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
        private Customer _customer;
        public int BookingId { get; set; }

        public string Name { get { return _customer.Name; } }

        public string Email { get { return _customer.Email; } }

        public int PhoneNumber { get { return _customer.PhoneNumber; } }

        public DateTime CheckInDate { get; set; }

        public DateTime CheckInTime { get; set; }

        public DateTime CheckOutDate { get; set; }

        public DateTime CheckOutTime { get; set; }

        public DateTime DateOfBooking { get; set; }

        public bool Breakfast { get; set; }

        public override void SetValuesFromObject(Booking obj)
        {
            BookingId = obj.BookingId;
            CheckInDate = obj.CheckInDate;
            CheckInTime = obj.CheckInTime;
            CheckOutDate = obj.CheckOutDate;
            CheckOutTime = obj.CheckOutTime;
            Breakfast = obj.Breakfast;
            DateOfBooking = obj.DateOfBooking;
        }
    }
}
