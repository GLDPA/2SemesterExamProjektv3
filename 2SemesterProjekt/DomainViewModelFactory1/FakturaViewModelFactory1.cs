﻿using System;
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
                BookingID = tObj.BookingID,
                Name = tObj.Name,
                Email = tObj.Email,
                DateOfFaktura = tObj.DateOfFaktura,
                FakturaId = tObj.FakturaId
            };
            return obj;
        }
    }
}
