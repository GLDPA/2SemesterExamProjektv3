using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Implementation;

namespace _2SemesterProjekt
{
    class CustomerDetailsViewModel : DetailsViewModelBase<CustomerViewModel>
    {
        public CustomerDetailsViewModel(CustomerViewModel obj) : base(obj)
        {
        }


        public string Name
        {
            get
            {
                return DataObject.Name;
            }
            set
            {
                DataObject.Name = value;
                OnPropertyChanged();
            }
        }

        public int Age
        {
            get
            {
                return DataObject.Age;
            }
            set
            {
                DataObject.Age = value;
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

        public int PhoneNumber
        {
            get
            {
                return DataObject.PhoneNumber;
            }
            set
            {
                DataObject.PhoneNumber = value;
                OnPropertyChanged();
                
            } 
        }


        public int NumberOfPeople
        {
            get { return DataObject.NumberOfPeople; }
            set
            {
                DataObject.NumberOfPeople = value;
                OnPropertyChanged();
            }
        }

        public int NumberOfChildren
        {
            get { return DataObject.NumberOfChildren; }
            set
            {
                DataObject.NumberOfChildren = value;
                OnPropertyChanged();
            }
        }

        public int NumberOfAnimals
        {
            get { return DataObject.NumberOfAnimals; }
            set
            {
                DataObject.NumberOfAnimals = value;
                OnPropertyChanged();
            }
        }



       
    }
}
