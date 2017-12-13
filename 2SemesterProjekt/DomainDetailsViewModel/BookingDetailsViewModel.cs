using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Implementation;

namespace _2SemesterProjekt.BookingFolder
{
    class BookingDetailsViewModel : DetailsViewModelBase<BookingVm>
    {


        public BookingDetailsViewModel(BookingVm obj) : base(obj)
        {
        }

        public DateTime CheckInDate
        {
            get { return DataObject.CheckInDate; } set { DataObject.CheckInDate = value; OnPropertyChanged(); }
        }

        public DateTime CheckInTime
        {
            get { return DataObject.CheckInTime; } set { DataObject.CheckInTime = value; OnPropertyChanged(); }
        }


        public DateTime CheckOutDate
        {
            get { return DataObject.CheckOutDate; } set { DataObject.CheckOutDate = value; OnPropertyChanged(); }
        }


        public DateTime CheckOutTime
        {
            get { return DataObject.CheckOutTime; } set { DataObject.CheckInTime = value; OnPropertyChanged(); }
        }
        public bool Breakfast
        {
            get { return DataObject.Breakfast; } set { DataObject.Breakfast = value; OnPropertyChanged(); }
        }
        public DateTime DateOfBooking
        {
            get { return DataObject.DateOfBooking; } set { DataObject.DateOfBooking = value; OnPropertyChanged(); }
        }

        public int BookingID
        {
            get { return DataObject.BookingID; } set { DataObject.BookingID = value; OnPropertyChanged(); }
        }

        // 1) we create a propety 
        // 2) we create a List object with string elements
        // 3) we run a foreach-loop in Customercatalog
        // 4) Add the names and return the list
        public List<string> CustomerNamesList
        {
            get
            {
                List<string> Names = new List<string>();
                foreach (var c in CustomerCatalog.Instance.All)
                {
                    Names.Add(c.Name);
                }
                return Names;
            }
        }

        private string _customerSelected;
        public string CustomerSelected
        {
            get { return _customerSelected; }
            set
            {
                _customerSelected = value;
                DataObject.CustomerName = _customerSelected;
            }
        }



        public List<string> SummerhouseNamesList
        {
            get
            {
                List<string> Names = new List<string>();
                foreach (var c in SummerHouseCatalog.Instance.All)
                {
                    Names.Add(c.NickName);
                }
                return Names;
            }
        }

        private string _summerHouseSelected;
        public string SummerHouseSelected
        {
            get { return _summerHouseSelected; }
            set
            {
                _summerHouseSelected = value;
                DataObject.SummerHouseName = _summerHouseSelected;
                OnPropertyChanged(nameof(TotalPrice));
            }
        }

        public double TotalPrice
        {
            get
            {
                SommerhusVm sh = GetSummerHouse(SummerHouseSelected);
                if (sh != null)
                {
                    int numberOfDays = CheckOutDate.Subtract(CheckInDate).Days;
                    return numberOfDays * sh.PricePrNight;
                }
                return 0;
            }
        }

        public SommerhusVm GetSummerHouse(string ID)
        {
            foreach (var sommerhus in SummerHouseCatalog.Instance.All)
            {
                if (sommerhus.NickName == ID)
                {
                    return sommerhus;
                }
            }

            return null;
        }
    }
}
