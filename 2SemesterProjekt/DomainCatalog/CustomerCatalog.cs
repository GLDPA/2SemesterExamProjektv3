using ExtensionsModel.Implementation;
using _2SemesterProjekt.DomainViewModelFactory1;

namespace _2SemesterProjekt
{
   public class CustomerCatalog : WebAPIPersistableCatalog<Customer, CustomerViewModel, DTO.Customer>
   {
       private static CustomerCatalog _instance;
       
        // Call on load method in our constructor  
       public CustomerCatalog() : base("http://localhost:49759/", "Customers",new CustomerViewModelFactory(), new CustomerDTOFactory())
       {

            Load();
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
