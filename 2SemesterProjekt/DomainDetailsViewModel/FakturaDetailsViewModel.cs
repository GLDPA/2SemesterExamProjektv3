using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Implementation;

namespace _2SemesterProjekt.Faktura
{
    class FakturaDetailsVM : DetailsViewModelBase<FakturaVM>
    {

        
        public FakturaDetailsVM(FakturaVM obj)
            : base(obj)
        {
        }
        public int FakturaId
        {
            get { return DataObject.BookingID; }
            set
            {
                DataObject.BookingID = value;OnPropertyChanged();
            }
        }
        public int BookingId
        {
            get { return DataObject.BookingID; }
            set
            {
                DataObject.BookingID = value;
                OnPropertyChanged();
            }
        }

       
        public string CustomerName
        {
            get { return DataObject.Name; }
            set
            {
                DataObject.Name = value;
                OnPropertyChanged();
            }
        }
        public string Email
        {
            get { return DataObject.Email; }
            set
            {
                DataObject.Email = value;
                OnPropertyChanged();
            }
        }
        public int PhoneNr
        {
            get { return DataObject.PhoneNr; }
            set
            {
                DataObject.PhoneNr = value;
                OnPropertyChanged();
            }
        }

        public double TotalPrice
        {
            get
            {
                return DataObject.TotalPrice;
            }
            set
            {
                DataObject.TotalPrice = value;
                OnPropertyChanged();
            }
        }
        public DateTime DateOfFaktura
        {
            get
            {
                return DataObject.DateOfFaktura;
            }
            set
            {
                DataObject.DateOfFaktura = value;
                OnPropertyChanged();
            }
        }
    }
}
