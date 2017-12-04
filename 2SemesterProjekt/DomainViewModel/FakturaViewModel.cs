using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Implementation;

namespace _2SemesterProjekt.Faktura
{
    public class FakturaVM : TransformedBase<Faktura>
    {
        public int BookingID { get; set; }
        public double PricePrNight { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int PhoneNr { get; set; }
        public int CardNr { get; set; }
        public int ExpMonth { get; set; }
        public int ExpYear { get; set; }
        public int CVC { get; set; }
        public double TotalPrice { get; set; }

        public override void SetValuesFromObject(Faktura obj)
        {
            Key = obj.Key;
            BookingID = obj.BookingID;
            PricePrNight = obj.PricePrNight;
            Name = obj.Name;
            Email = obj.Email;
            PhoneNr = obj.PhoneNr;
            CardNr = obj.CardNr;
            ExpMonth = obj.ExpMonth;
            ExpYear = obj.ExpYear;
            CVC = obj.CVC;
            TotalPrice = obj.TotalPrice;
        }
        
    }
}


