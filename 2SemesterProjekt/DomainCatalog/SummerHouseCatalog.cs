    using Windows.UI.Xaml.Navigation;
using ExtensionsModel.Implementation;
using _2SemesterProjekt.DomainViewModelFactory1;

namespace _2SemesterProjekt
{
  public  class SummerHouseCatalog : WebAPIPersistableCatalog<SummerHouse, SommerhusVm, DTO.SommerhusTable>
    {
        private static SummerHouseCatalog instance;
        public static SummerHouseCatalog Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SummerHouseCatalog();
                }
                return instance;
            }
        }

        public SummerHouseCatalog() : base("http://sommerhusprojektwebservice2017v1206.azurewebsites.net/", "SommerhusTables", new SummerHouseVmFactory1(), new SummerHouseDTOFactory())
        {
           Load(); 
        }
    }
}
