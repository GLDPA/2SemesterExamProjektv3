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
      BookingID = dtoObj.bookingNummer,
                InvoiceNumber = dtoObj.fakturaNummer,
                TotalPrice = dtoObj.Total_pris,
                DateOfInvoice = dtoObj.datoForFaktura,
                DateOfBooking = dtoObj.datoForFaktura,
                Breakfast = dtoObj.morgenmad,
                //PhoneNumber = dtoObj.Tlf_Nr,
                //SummerhouseName = dtoObj.sommerhusNavn


            };

            return booking;

        }
    }
}
