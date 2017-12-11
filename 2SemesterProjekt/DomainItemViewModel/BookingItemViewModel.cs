using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Implementation;
using DataTransformation.Interfaces;

namespace _2SemesterProjekt.BookingFolder
{
    class BookingItemVm : DataWrapper<BookingVm>
    {
        public BookingItemVm(BookingVm obj) : base(obj)
        {
        }

     

        public int BookingId { get { return DataObject.BookingID; } }

        //public string Name { get { return DataObject.Name; } }

        //public string Email { get { return DataObject.Email; } }

        //public int PhoneNumber { get { return DataObject.PhoneNumber; } }

        public DateTime CheckInDate { get { return DataObject.CheckInDate; } }

        public DateTime CheckInTime { get { return DataObject.CheckInTime; } }

        public  DateTime CheckOutDate { get { return DataObject.CheckOutDate; } }

        public  DateTime CheckOutTime { get { return DataObject.CheckOutTime; }}

        public DateTime DateOfBooking { get { return DataObject.DateOfBooking; } }

    }
}
