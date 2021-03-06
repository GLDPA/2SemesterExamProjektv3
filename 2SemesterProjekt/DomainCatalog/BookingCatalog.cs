﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Interfaces;
using ExtensionsModel.Implementation;
using _2SemesterProjekt.DomainViewModelFactory1;
using _2SemesterProjekt.DTO;

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
       
        public BookingCatalog() : base("http://examprojektwebservice20171215.azurewebsites.net/", "BookingFakturas", new BookingViewModelFactory(), new BookingDTOFactory())
        {
           Load();  
            
        }
    }
}
