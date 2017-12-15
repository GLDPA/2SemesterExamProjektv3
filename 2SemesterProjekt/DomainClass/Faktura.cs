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

        public int FakturaId { get; set; }

        public int BookingID { get { return _booking.BookingID; } set { value = _booking.BookingID; } }

        public string Name { get { return _customer.Name; } set { value = _customer.Name; } }

        public string Email { get { return _customer.Email; } set { value = _customer.Email; } }

        public int PhoneNr { get { return _customer.PhoneNumber; } set { value = _customer.PhoneNumber; } }

        public DateTime DateOfFaktura { get; set; }

        public double TotalPrice { get { return _booking.TotalPrice; } set { value = _booking.TotalPrice; } }


        
        public override void SetValuesFromObject(Faktura obj)
        {
            BookingID =obj.BookingID;
            Name = obj.Name;
            Email = obj.Email;
            PhoneNr = obj.PhoneNr;
            TotalPrice = obj.TotalPrice;
            FakturaId = obj.FakturaId;
        }
    } 
}
