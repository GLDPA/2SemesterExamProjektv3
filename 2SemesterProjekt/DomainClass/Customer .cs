using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Implementation;
using DataTransformation.Interfaces;
using InMemoryStorage.Interfaces;

namespace _2SemesterProjekt
{
   public class Customer : TransformedBase<Customer>
   {

        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public int CardNumber { get; set; }
        public int CVC { get; set; }
        public int ExpirationMonth { get; set; }
        public int ExpirationYear { get; set; }
        public int NumberOfPeople { get; set; }
        public int NumberOfChildren { get; set; }
        public  int NumberOfAnimals { get; set; }
    
        
        public int Key { get; set; }
       

       public override void SetValuesFromObject(Customer obj)
       {
          Name = obj.Name;
           Age = obj.Age;
           Email = obj.Email;
           PhoneNumber = obj.PhoneNumber;
           CardNumber = obj.CardNumber;
           CVC = obj.CVC;
           ExpirationMonth = obj.ExpirationMonth;
           ExpirationYear = obj.ExpirationYear;
           NumberOfPeople = obj.NumberOfPeople;
           NumberOfChildren = obj.NumberOfChildren;
           NumberOfAnimals = obj.NumberOfAnimals;
       }


       
   }
}
