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
        public double TotalPrice
        {
            get { return DataObject.TotalPrice; } set { DataObject.TotalPrice = value; OnPropertyChanged(); }
        }
        public int BookingID
        {
            get { return DataObject.BookingID; } set { DataObject.BookingID = value; OnPropertyChanged(); }
        }
    }
}
