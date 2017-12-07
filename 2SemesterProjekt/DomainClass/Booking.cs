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
        private SummerHouse _summerHouse;
        private DateTime _dayofweek;
        private Booking _booking;
        
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

        public int PriceForBreakfast { get; set; }

        public int PriceForAnimals { get; set; }

        public double CalculatePrice()
        {
           return _summerHouse.PricePrNight - (10.0 / 100.0) * _summerHouse.PricePrNight;
        }


        public double GetPrice()
        {
            double Price = _summerHouse.PricePrNight;
            switch (DateTime.Today.DayOfWeek.ToString())
            {
                case "Monday":
                    Price = CalculatePrice();
                    break;
                case "Tuesday":
                    Price = CalculatePrice();
                    break;
                case "Wednesday":
                    Price = CalculatePrice();
                    break;
                case "Thursday":
                    CalculatePrice();
                    break;
            }

            return Price;
            
        }
       

        public TimeSpan NumberOfDays { get { return CheckOutDate - CheckInDate; } set { value = NumberOfDays; } }

        public double TotalPrice
        {
            get
            {
                return (NumberOfDays.Days * GetPrice())
                       + ((PriceForBreakfast * (_customer.NumberOfPeople + _customer.NumberOfChildren)) * NumberOfDays.Days)
                       + (PriceForAnimals * _customer.NumberOfAnimals);
            }
            set { value = TotalPrice; }
        }


        public override void SetValuesFromObject(Booking obj)
        {
            BookingId = obj.BookingId;
            CheckInDate = obj.CheckInDate;
            CheckInTime = obj.CheckInTime;
            CheckOutDate = obj.CheckOutDate;
            CheckOutTime = obj.CheckOutTime;
            Breakfast = obj.Breakfast;
            DateOfBooking = obj.DateOfBooking;
            TotalPrice = obj.TotalPrice;
        }
    }
}
