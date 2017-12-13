using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Implementation;
using InMemoryStorage.Implementation;

namespace _2SemesterProjekt.InspectionFolder
{
    public class Inspection : TransformedBase<Inspection>
    {
        public bool IsClean { get; set; }
        public bool KeyIsReturned { get; set; }
        public bool SheetIsChanged { get; set; }
        public bool HouseIsNotDestroyed { get; set; }
        public string AllIsWell { get; set; }
        public int InspectionId { get; set; }
        public DateTimeOffset DateOfInspection { get; set; }

        public override void SetValuesFromObject(Inspection obj)
        {

            Key = NullKey;
            DateOfInspection = obj.DateOfInspection;
            InspectionId = obj.InspectionId;
            IsClean = obj.IsClean;
            KeyIsReturned = obj.KeyIsReturned;
            HouseIsNotDestroyed = obj.HouseIsNotDestroyed;
            SheetIsChanged = obj.SheetIsChanged;
            AllIsWell = "(All Is Well)";
        }
    }
}
