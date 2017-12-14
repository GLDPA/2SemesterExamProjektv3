using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Implementation;
using _2SemesterProjekt.BookingFolder;
using _2SemesterProjekt.DTO;

namespace _2SemesterProjekt.DomainViewModelFactory1
{
     public class BookingDTOFactory : FactoryBase<BookingFolder.Booking, _2SemesterProjekt.DTO.BookingFaktura>
    {
        public override Booking CreateDomainObject(_2SemesterProjekt.DTO.BookingFaktura dtoObj)
        {
            Booking booking = new Booking()
            {
                CheckInDate = dtoObj.checkIndDato,
                CheckOutDate = dtoObj.checkUdDato,

            };

            return booking;

        }
    }
}
