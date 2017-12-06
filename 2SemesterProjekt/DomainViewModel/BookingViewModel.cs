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
        private Customer _customer;
        private SummerHouse _summerhouse;
        public string Name { get { return _customer.Name; } }

        public string Email { get { return _customer.Email; } }

        public int PhoneNumber { get { return _customer.PhoneNumber; } }

        public DateTime CheckInDate { get; set; }

        public DateTime CheckInTime { get; set; }

        public DateTime CheckOutTime { get; set; }

        public DateTime CheckOutDate { get; set; }

        public bool Breakfast { get; set; }

        public DateTime DateOfBooking { get; set; }

        public int PriceForBreakfast { get; set; }

        public int PriceForAnimals { get; set; }

        public TimeSpan NumberOfDays { get { return CheckOutDate - CheckInDate; } set { value = NumberOfDays; } }

        public double TotalPrice
        {
            get
            {
                return (NumberOfDays.Days * _summerhouse.PricePrNight)
                       + ((PriceForBreakfast * (_customer.NumberOfPeople + _customer.NumberOfChildren)) * NumberOfDays.Days)
                       + (PriceForAnimals * _customer.NumberOfAnimals);
            }
            set { value = TotalPrice; }
        }

        public override void SetValuesFromObject(Booking obj)
        {
            Key = obj.Key;
            CheckInDate = obj.CheckInDate;
            CheckInTime = obj.CheckInTime;
            CheckOutTime = obj.CheckOutTime;
            CheckOutDate = obj.CheckOutDate;
            Breakfast = obj.Breakfast;
            DateOfBooking = obj.DateOfBooking;
            TotalPrice = obj.TotalPrice;
        }
    }
}
