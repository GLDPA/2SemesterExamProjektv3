﻿using System;
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
       private int _phoneNr;

        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

       public int PhoneNumber
       {
           get { return _phoneNr; }
           set
           {
               _phoneNr = value;
               Key = _phoneNr;
           }
       }

        public int NumberOfPeople { get; set; }
        public int NumberOfChildren { get; set; }
        public int NumberOfAnimals { get; set; }


       public override void SetValuesFromObject(Customer obj)
        {
           Key = obj.Key;
           Name = obj.Name;
           Age = obj.Age;
           Email = obj.Email;
           PhoneNumber = obj.PhoneNumber;
           NumberOfPeople = obj.NumberOfPeople;
           NumberOfChildren = obj.NumberOfChildren;
           NumberOfAnimals = obj.NumberOfAnimals;
       }



      
    }
}
