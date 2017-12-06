    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Store.Preview.InstallControl;
using Windows.Graphics.Printing;
using Catalog.Implementation;
    using DataTransformation.Implementation;
    using DataTransformation.Interfaces;
using ExtensionsModel.Implementation;
using InMemoryStorage.Interfaces; 

namespace _2SemesterProjekt
{
   public class CustomerCatalog : WebAPIPersistableCatalog<Customer, CustomerViewModel, Customer>
   {
       private static CustomerCatalog _instance;
       
       public CustomerCatalog() : base("http://sommerhusprojektwebservice2017v1206.azurewebsites.net/", "Customers",new CustomerViewModelFactory(), new IdenticalDataFactory<Customer>())
       {
       }

       public static CustomerCatalog Instance
       {
           get
            {
               if (_instance == null)
               {
                   _instance = new CustomerCatalog();
               }
               return _instance;
           } 
       }
   }

    
}
