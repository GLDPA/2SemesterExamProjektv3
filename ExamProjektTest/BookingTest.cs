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
            Booking booking = new Booking();
            summerHouse.PricePrNight = 300;
            booking.CheckInDate = new DateTime(2017, 12, 7);
            booking.CheckOutDate = new DateTime(2017, 12, 10);
            double expectedresult = 900;
            TimeSpan numberofdays = booking.CheckOutDate - booking.CheckInDate;

            //Act
            double actualresult = (numberofdays.Days * booking.GetPrice());

            //Assert
            Assert.AreEqual(expectedresult, actualresult);
        }
    }
}
