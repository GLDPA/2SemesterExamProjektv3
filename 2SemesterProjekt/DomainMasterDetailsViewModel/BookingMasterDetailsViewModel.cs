using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ExtensionsViewModel.Implementation;

namespace _2SemesterProjekt.BookingFolder
{
    class BookingMasterDetailsViewModel : MasterDetailsViewModelCRUD<Booking, BookingVm, Booking>
    {
        public BookingMasterDetailsViewModel()
            : base(new BookingVmFactory(), ObjectProvider.BookingCatalog,
                new List<string> { }, new List<string>())
        { }


        // 1) we create a propety 
        // 2) we create a List object with string elements
        // 3) we run a foreach-loop in Customercatalog
        // 4) Add the names and return the list
        public List<string> CustomerNamesList
        {
            get
            {
                List<string> Names = new List<string>();
                foreach (var c in CustomerCatalog.Instance.All)
                {
                    Names.Add(c.Name);
                }
                return Names;
            }
        }



        public List<string> SummerhouseNamesList
        {
            get
            {
                List<string> Names = new List<string>();
                foreach (var c in SummerHouseCatalog.Instance.All)
                {
                    Names.Add(c.NickName);
                }
                return Names;
            }
        }


    }
}
