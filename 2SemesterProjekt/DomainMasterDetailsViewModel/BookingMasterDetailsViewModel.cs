using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ExtensionsCommands.Types;
using ExtensionsViewModel.Implementation;
using _2SemesterProjekt.DTO;

namespace _2SemesterProjekt.BookingFolder
{
    class BookingMasterDetailsViewModel : MasterDetailsViewModelCRUD<Booking, BookingVm,  >
    {
        public BookingMasterDetailsViewModel()
            : base(new BookingVmFactory(), ObjectProvider.BookingCatalog,
                new List<string> { }, new List<string>())
        {
            ViewStateService.ViewState = CRUDStates.CreateState;
        }





    }
}
