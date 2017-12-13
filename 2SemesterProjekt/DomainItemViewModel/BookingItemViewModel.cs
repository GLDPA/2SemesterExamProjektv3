using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Implementation;
using DataTransformation.Interfaces;

namespace _2SemesterProjekt.BookingFolder
{
    class BookingItemVm : DataWrapper<BookingVm>
    {
        public BookingItemVm(BookingVm obj) : base(obj)
        {
        }
        
        public int Description
        {
            get { return DataObject.BookingID; }

        }

    }
}
