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

        private Customer _customerName;

        
        public int PhoneNumber { get; set; }
        public string SummerhouseName { get; set; }
        public int InvoiceNumber { get; set; }
    
        public int BookingID { get; set; }

        public DateTime DateOfBooking { get; set; }

        public DateTimeOffset CheckInDate { get; set; }

        public DateTimeOffset CheckOutDate { get; set; }

        public bool Breakfast { get; set; }

        public DateTime CheckInTime { get; set; }

        public DateTime CheckOutTime { get; set; }



        //public string Name { get { return _customer.Name; } }

        //public string Email { get { return _customer.Email; } }

        //public int PhoneNumber { get { return _customer.PhoneNumber; } }




   

        public double CalculatePrice()
        {

           return ((_summerHouse.PricePrNight - 10.0) / 100.0) * _summerHouse.PricePrNight;

           //return _summerHouse.PricePrNight - 10.0/ 100.0 * _summerHouse.PricePrNight;

        }


        public double GetPrice()
        {

            double Price =_summerHouse.PricePrNight;
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
            get { return (NumberOfDays.Days * GetPrice()); }
            set { value = TotalPrice; }
        }


        public override void SetValuesFromObject(Booking obj)
        {
            InvoiceNumber = obj.InvoiceNumber;
            BookingID = obj.BookingID;
            CheckInDate = obj.CheckInDate;
            CheckInTime = obj.CheckInTime;
            CheckOutDate = obj.CheckOutDate;
            CheckOutTime = obj.CheckOutTime;
            Breakfast = obj.Breakfast;
            DateOfBooking = obj.DateOfBooking;
            TotalPrice = obj.TotalPrice;
            PhoneNumber = obj.PhoneNumber;
            SummerhouseName = obj.SummerhouseName;
        }
    }
}
