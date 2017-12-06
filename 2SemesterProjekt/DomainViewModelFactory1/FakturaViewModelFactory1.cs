using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Implementation;

namespace _2SemesterProjekt.Faktura
{
    public class FakturaVmFactory1 : FactoryBase<Faktura, FakturaVM>
    {
        public override Faktura CreateDomainObject(FakturaVM tObj)
        {
            Faktura obj = new Faktura
            {
                Key = tObj.Key,
                CustomerId = tObj.CustomerId,
                BookingID = tObj.BookingID,
                Name = tObj.Name,
                Email = tObj.Email,
                CardNr = tObj.CardNr,
                ExpMonth = tObj.ExpMonth,
                ExpYear = tObj.ExpYear,
                CVC = tObj.CVC,
                DateOfFaktura = tObj.DateOfFaktura,
                FakturaId = tObj.FakturaId
            };
            return obj;
        }
    }
}
