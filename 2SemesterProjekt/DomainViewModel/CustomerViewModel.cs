using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Implementation;

namespace _2SemesterProjekt
{
    public class CustomerViewModel : TransformedBase<Customer>
    {
        private int _customerId;
        private string _name;
        private int _age;
        private string _email;
        private int _phonenumber;
        private int _cardnumber;
        private int _cvc;
        private int _expirationMonth;
        private int _expirationYear;
        private int _numberOfPeople;
        private int _numberOfChildren;
        private int _numberOfAnimals;

        public int CustomerId { get { return _customerId; } set { value = _customerId; } }
        public string Name { get { return _name; } set { value = _name; } }
        public int Age { get { return _age; } set { value = _age; } }
        public string Email { get { return _email; } set { value = _email; } }
        public int PhoneNumber { get { return _phonenumber; } set { value = _phonenumber; } }
        public int Cardnumber { get { return _cardnumber; } set { value = _cardnumber; } }
        public int CVC { get { return _cvc; } set { value = _cvc; } }
        public int ExpirationMonth { get { return _expirationMonth; } set { value = _expirationMonth; } }
        public int ExpirationYear { get { return _expirationYear; } set { value = _expirationYear; } }
        public int NumberOfPeople { get { return _numberOfPeople; }set { value = _numberOfPeople; } }
        public int NumberOfChildren { get { return _numberOfChildren; }set { value = _numberOfChildren; } }
        public int NumberOfAnimals { get { return _numberOfAnimals; }set { value = _numberOfChildren; } }
        public override void SetValuesFromObject(Customer obj)
        {
            Key = obj.Key;
            CustomerId = obj.CustomerId;
            Name = obj.Name;
            Age = obj.Age;
            Email = obj.Email;
            PhoneNumber = obj.PhoneNumber;
            Cardnumber = obj.CardNumber;
            CVC = obj.CVC;
            ExpirationMonth = obj.ExpirationMonth;
            ExpirationYear = obj.ExpirationYear;
            NumberOfPeople = obj.NumberOfPeople;
            NumberOfChildren = obj.NumberOfChildren;
            NumberOfAnimals = obj.NumberOfAnimals;
        }
    }
}
