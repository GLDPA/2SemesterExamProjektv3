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
        private string _name;
        private int _age;
        private string _email;
        private int _phonenumber;
        private int _cardnumber;
        private int _cvr;
        private int _expirationMonth;
        private int _expirationYear;


        public string Name { get { return _name; } set { value = _name; } }
        public int Age { get { return _age; } set { value = _age; } }
        public string Email { get { return _email; } set { value = _email; } }
        public int PhoneNumber { get { return _phonenumber; } set { value = _phonenumber; } }
        public int Cardnumber { get { return _cardnumber; } set { value = _cardnumber; } }
        public int CVRNumber { get { return _cvr; } set { value = _cvr; } }
        public int ExpirationMonth { get { return _expirationMonth; } set { value = _expirationMonth; } }
        public int ExpirationYear { get { return _expirationYear; } set { value = _expirationYear; } }

        public override void SetValuesFromObject(Customer obj)
        {
            Key = obj.Key;
            Name = obj.Name;
            Age = obj.Age;
            Email = obj.Email;
            PhoneNumber = obj.PhoneNumber;
            Cardnumber = obj.CardNumber;
            CVRNumber = obj.CVRNumber;
            ExpirationMonth = obj.ExpirationMonth;
            ExpirationYear = obj.ExpirationYear;
        }
    }
}
