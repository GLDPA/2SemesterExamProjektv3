using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Implementation;
using DataTransformation.Interfaces;
using InMemoryStorage.Implementation;

namespace _2SemesterProjekt.Faktura
{
    public class Faktura : TransformedBase<Faktura>
    {
        public int BookingID { get; set; }
        public int Price { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public int PhoneNr { get; set; }
        public int CardNr { get; set; }
        public int ExpMonth { get; set; }
        public int ExpYear { get; set; }
        public int CVC { get; set; }
        public override void SetValuesFromObject(Faktura obj)
        {
            BookingID =obj.BookingID;
            Price = obj.Price;
            CustomerName = obj.CustomerName;
            Email = obj.Email;
            PhoneNr = obj.PhoneNr;
            CardNr = obj.CardNr;
            ExpMonth = obj.ExpMonth;
            ExpYear = obj.ExpYear;
            CVC = obj.CVC;
        }
        

       
    }
}
