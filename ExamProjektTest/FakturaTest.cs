using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2SemesterProjekt;
using _2SemesterProjekt.BookingFolder;
using _2SemesterProjekt.Faktura;

namespace ExamProjektTest
{
    [TestClass]
    class FakturaTest
    {
        [TestMethod]
        public void TotalPriceTest()
        {
            //Arrange
            Faktura faktura = new Faktura();
            SummerHouse summerHouse = new SummerHouse();
            Customer customer = new Customer();
            Booking booking = new Booking();
            summerHouse.PricePrNight = 300;
            customer.NumberOfPeople = 2;
            customer.NumberOfChildren = 2;
            customer.NumberOfAnimals = 1;
            booking.CheckInDate = DateTime.Today;
            booking.CheckOutDate = new DateTime(8/12/2017);
            double expectedresult = 2200;
            TimeSpan numberofdays = booking.CheckOutDate - booking.CheckInDate;

            //Act
            faktura.TotalPrice = (numberofdays.Days * summerHouse.PricePrNight) 
                + (booking.PriceForBreakfast *(customer.NumberOfPeople + customer.NumberOfChildren) * numberofdays.Days) 
                + (booking.PriceForAnimals * customer.NumberOfAnimals) ;

            //Assert
            Assert.AreEqual(expectedresult,faktura.TotalPrice);
        }
    }
}
