using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalog.Implementation;
using ExtensionsCommands.Types;
using ExtensionsViewModel.Implementation;
using ViewModel.Interfaces;
using _2SemesterProjekt.SummerHouseMappe;

namespace _2SemesterProjekt
{
    public class SummerHouseMasterDetailsVm : MasterDetailsViewModelCRUD<SummerHouse, SommerhusVm, DTO.SommerhusTable>
    {
        public SummerHouseMasterDetailsVm()
            : base(new SummerhouseVmFactory2(),
                ObjectProvider.SummerHouseCatalog,
                new List<string>{},
                new List<string>{})
        {
            ViewStateService.ViewState = CRUDStates.CreateState;
        }
    }
}
