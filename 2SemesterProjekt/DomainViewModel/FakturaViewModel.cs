using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Implementation;
using _2SemesterProjekt.BookingFolder;

namespace _2SemesterProjekt.Faktura
{
    public class FakturaVM : TransformedBase<Faktura>
    {
        
        private Customer _customer;

        private SummerHouse _summerHouse;

        private Booking _booking;

        public int FakturaId { get; set; }

        public int BookingID { get { return _booking.BookingID; } set { value = _booking.BookingID; } }


        public string Name { get { return _customer.Name; } set { value = _customer.Name; } }

        public string Email { get { return _customer.Email; } set { value = _customer.Email; } }

        public int PhoneNr { get { return _customer.PhoneNumber; } set { value = _customer.PhoneNumber; } }

        public DateTime DateOfFaktura { get; set; }

        public double TotalPrice
        {
            get
            {
                TotalPrice = _summerHouse.PricePrNight * (_customer.NumberOfPeople + _customer.NumberOfChildren);
                if (_customer.NumberOfAnimals > 0)
                {
                    TotalPrice = TotalPrice + 200;
                }
                return TotalPrice
                    ;
            }
            set { value = TotalPrice; }
        }
        public override void SetValuesFromObject(Faktura obj)
        {
            Key = obj.Key;
            BookingID = obj.BookingID;
            Name = obj.Name;
            Email = obj.Email;
            PhoneNr = obj.PhoneNr;
            TotalPrice = obj.TotalPrice;
            DateOfFaktura = obj.DateOfFaktura;
            FakturaId = obj.FakturaId;
        }
        
    }
}


