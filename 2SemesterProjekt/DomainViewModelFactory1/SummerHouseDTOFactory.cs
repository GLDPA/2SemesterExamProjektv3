using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Implementation;
using _2SemesterProjekt.DTO;

namespace _2SemesterProjekt.DomainViewModelFactory1
{
   public class SummerHouseDTOFactory : FactoryBase<SummerHouse, _2SemesterProjekt.DTO.SommerhusTable>
    {
        public override SummerHouse CreateDomainObject(SommerhusTable tObj)
        {
            SummerHouse summerhouse = new SummerHouse()

            {
                StreetName = tObj.vejNavn,
                StreetNr = tObj.vejNummer,
                ZipCode = tObj.postNummer,
                City = tObj.by,
                Municipality = tObj.kommune,
                NickName = tObj.sommerhusNavn
            };


            return summerhouse;
        }
    }
}
