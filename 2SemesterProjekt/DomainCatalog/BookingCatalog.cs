using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Interfaces;
using ExtensionsModel.Implementation;
using _2SemesterProjekt.DomainViewModelFactory1;

namespace _2SemesterProjekt.BookingFolder
{
   public class BookingCatalog : WebAPIPersistableCatalog<Booking, BookingVm, DTO.BookingFaktura> //FilePersistableCatalogNoDTO<Booking, BookingVm>
    {
        private static BookingCatalog _instance;
        public static BookingCatalog Instance
        {
            get
            {
                if (_instance == null)
                {
                   _instance = new BookingCatalog();
                }
                return _instance;
            }
        }
       
        public BookingCatalog() : base("http://localhost:2235/", "BookingFakturas", new BookingViewModelFactory(), new BookingDTOFactory())
        {
           Load();  
            
        }
    }
}
