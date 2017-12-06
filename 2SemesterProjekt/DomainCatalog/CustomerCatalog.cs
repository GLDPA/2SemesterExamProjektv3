using ExtensionsModel.Implementation;
using _2SemesterProjekt.DomainViewModelFactory1;

namespace _2SemesterProjekt
{
   public class CustomerCatalog : WebAPIPersistableCatalog<Customer, CustomerViewModel, DTO.Customer>
   {
       private static CustomerCatalog _instance;
       
       public CustomerCatalog() : base("http://sommerhusprojektwebservice2017v1206.azurewebsites.net/", "Customers",new CustomerViewModelFactory(), new CustomerDTOFactory())
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
