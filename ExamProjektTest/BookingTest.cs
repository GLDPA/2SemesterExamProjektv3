using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2SemesterProjekt;
using _2SemesterProjekt.BookingFolder;


namespace ExamProjektTest
{
    [TestClass]
    public class BookingTest
    {
        [TestMethod]
        public void TotalPriceTest()
        {
            //Arrange
            SummerHouse summerHouse = new SummerHouse();
            //Customer customer = new Customer();
            Booking booking = new Booking();
            summerHouse.PricePrNight = 300;
            //customer.NumberOfPeople = 2;
            //customer.NumberOfChildren = 2;
            //customer.NumberOfAnimals = 1;
            booking.CheckInDate = new DateTime(2017, 12, 7);
            booking.CheckOutDate = new DateTime(2017, 12, 10);
            double expectedresult = 900;
            TimeSpan numberofdays = booking.CheckOutDate - booking.CheckInDate;
            //booking.PriceForBreakfast = 75;
            //booking.PriceForAnimals = 200;

            //Act
            double actualresult = (numberofdays.Days * booking.GetPrice());
                                  //+ ((booking.PriceForBreakfast * (customer.NumberOfPeople + customer.NumberOfChildren)) * numberofdays.Days)
                                  //+ (booking.PriceForAnimals * customer.NumberOfAnimals);

            //Assert
            Assert.AreEqual(expectedresult, actualresult);
        }
    }
}
