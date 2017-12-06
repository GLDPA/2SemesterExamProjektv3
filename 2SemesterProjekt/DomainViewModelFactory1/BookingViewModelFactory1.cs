using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Implementation;

namespace _2SemesterProjekt.BookingFolder
{
   public class BookingViewModelFactory : FactoryBase<Booking, BookingVm>
    {
        public override Booking CreateDomainObject(BookingVm tObj)
        {
            Booking booking = new Booking
            {
                Key = tObj.Key,
                CheckInDate = tObj.CheckInDate,
                CheckInTime = tObj.CheckInTime,
                CheckOutTime = tObj.CheckOutTime,
                CheckOutDate = tObj.CheckOutDate,
                Breakfast = tObj.Breakfast,
                DateOfBooking = tObj.DateOfBooking,
                TotalPrice = tObj.TotalPrice
            };

            return booking;
        }
    }
}
