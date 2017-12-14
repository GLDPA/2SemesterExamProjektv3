using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Implementation;

namespace _2SemesterProjekt.DomainViewModelFactory1
{
    public class CustomerDTOFactory : FactoryBase<Customer, _2SemesterProjekt.DTO.Customer>
    {
        public override Customer CreateDomainObject(_2SemesterProjekt.DTO.Customer dtoObj)
        {
            Customer customer = new Customer

            {
                Key = dtoObj.Key,
                Name = dtoObj.Navn,
                Age = dtoObj.Alder,
                Email = dtoObj.Email,
                PhoneNumber = dtoObj.TlfNr,
                NumberOfPeople = dtoObj.antalPersoner,
                NumberOfChildren = dtoObj.antalBørn,
                NumberOfAnimals = dtoObj.antalDyr
            };


            return customer;
        }
    
    }
}
