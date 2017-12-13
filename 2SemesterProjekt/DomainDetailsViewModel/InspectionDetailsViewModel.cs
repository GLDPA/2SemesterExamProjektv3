using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Implementation;

namespace _2SemesterProjekt.InspectionFolder
{
    public class InspectionDetailsVm : DetailsViewModelBase<InspectionVm>
    {
        public InspectionDetailsVm(InspectionVm obj) 
            : base(obj)
        {
        }

        public bool IsClean
        {
            get { return DataObject.IsClean; }
            set
            {
                DataObject.IsClean = value;
                OnPropertyChanged();
            }
        }
        public bool KeyIsReturned
        {
            get { return DataObject.KeyIsReturned; }
            set
            {
                DataObject.KeyIsReturned = value;
                OnPropertyChanged();
            }
        }
        public bool SheetIsChanged
        {
            get { return DataObject.SheetIsChanged; }
            set
            {
                DataObject.SheetIsChanged = value;
                OnPropertyChanged();
            }
        }
        public bool HouseIsNotDestroyed
        {
            get { return DataObject.HouseIsNotDestroyed; }
            set
            {
                DataObject.HouseIsNotDestroyed = value;
                OnPropertyChanged();
            }
        }
        public string AllIsWell
        {
            get { return DataObject.AllIsWell; }
            set
            {
                DataObject.AllIsWell = value;
                OnPropertyChanged();
            }
        }
        public DateTimeOffset DateOfInspection
        {
            get { return DataObject.DateOfInspection; }
            set
            {
                DataObject.DateOfInspection = value;
                OnPropertyChanged();
            }
        }
        public int InspectionId
        {
            get { return DataObject.InspectionId; }
            set
            {
                DataObject.InspectionId = value;
                OnPropertyChanged();
            }
        }
    }
}
