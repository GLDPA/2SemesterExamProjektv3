﻿using System;
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

<<<<<<< HEAD
        public DateTime CheckInDate { get; set; }
=======
        // public string Name { get { return _customer.Name; } }

        // public string Email { get { return _customer.Email; } }

        // public int PhoneNumber { get { return _customer.PhoneNumber; } }

        public DateTimeOffset CheckInDate { get; set; }
>>>>>>> origin/TestingG

        public DateTime CheckInTime { get; set; }

        public DateTime CheckOutTime { get; set; }

        public DateTimeOffset CheckOutDate { get; set; }

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
