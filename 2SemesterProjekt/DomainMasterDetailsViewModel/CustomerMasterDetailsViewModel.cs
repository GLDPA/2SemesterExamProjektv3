﻿using System;
using System.Collections.Generic;
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
    public class CustomerMasterDetailsViewModel : MasterDetailsViewModelCRUD<Customer,CustomerViewModel, DTO.Customer>
    {
        public CustomerMasterDetailsViewModel()
            : base(new CustomerVMFactory(),
                ObjectProvider.CustomerCatalog,
                new List<string>{},
                new List<string>{})
        {
            ViewStateService.ViewState = CRUDStates.CreateState;
        }
    }
}
