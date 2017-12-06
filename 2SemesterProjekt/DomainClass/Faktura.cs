using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Implementation;
using DataTransformation.Interfaces;
using InMemoryStorage.Implementation;
using _2SemesterProjekt.BookingFolder;

namespace _2SemesterProjekt.Faktura
{
    public class Faktura : TransformedBase<Faktura>
    {
        private Customer _customer;

        private SummerHouse _summerHouse;

        private Booking _booking;

        public int BookingID { get { return _booking.BookingId; } set { value = _booking.BookingId; } }

        public int CustomerId { get { return _customer.CustomerId; }set { value = _customer.CustomerId; } }

        public string Name { get { return _customer.Name; } set { value = _customer.Name; } }

        public string Email { get { return _customer.Email; } set { value = _customer.Email; } }

        public int PhoneNr { get { return _customer.PhoneNumber; } set { value = _customer.PhoneNumber; } }

        public int CardNr { get { return _customer.CardNumber; } set { value = _customer.CardNumber; } }

        public int ExpMonth { get { return _customer.ExpirationMonth; } set { value = _customer.ExpirationMonth; } }

        public int ExpYear { get { return _customer.ExpirationYear; } set { value = _customer.ExpirationYear; } }

        public int CVC { get { return _customer.CVC; } set { value = _customer.CVC; } }

<<<<<<< HEAD
        public DateTime DateOfFaktura { get; set; }
=======

        public double TotalPrice { get; set; }
>>>>>>> UnitTestingProjekt

        
        public override void SetValuesFromObject(Faktura obj)
        {
            BookingID =obj.BookingID;
            CustomerId = obj.CustomerId;
            Name = obj.Name;
            Email = obj.Email;
            PhoneNr = obj.PhoneNr;
            CardNr = obj.CardNr;
            ExpMonth = obj.ExpMonth;
            ExpYear = obj.ExpYear;
            CVC = obj.CVC;
        }
        
    } // (antal personer * prisen for morgenmad pr person * med antal dage/nætter) + (PrisPrNat * antal dage/nætter) +((evt pris for dyr (* antal nætter))) = TotalPris
}
