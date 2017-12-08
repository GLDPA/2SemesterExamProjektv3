using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Interfaces;
using ExtensionsModel.Implementation;

namespace _2SemesterProjekt.Faktura
{
    public class FakturaCatalog : FilePersistableCatalogNoDTO<Faktura, FakturaVM>
    {

        private static FakturaCatalog _instance;

        public FakturaCatalog() : base(new FakturaVmFactory1())
        {
        }

        public static FakturaCatalog Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FakturaCatalog();
                }
                return _instance;
            }
        }
    }
}
