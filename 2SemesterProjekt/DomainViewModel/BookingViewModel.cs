﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Implementation;

namespace _2SemesterProjekt.BookingFolder
{
 public  class BookingVm : TransformedBase<Booking>
 {
     public int InvoiceNumber { get; set; }

    public int PhoneNumber { get; set; }

    public string SummerhouseName { get; set; }

     public int BookingID { get; set; }

     public DateTime DateOfBooking { get; set; }

        public DateTime DateOfInvoice { get; set; }

     public DateTimeOffset CheckInDate { get; set; }
     public DateTimeOffset CheckOutDate { get; set; }


     public bool Breakfast { get; set; }

     public DateTime CheckInTime { get; set; }

     public DateTime CheckOutTime { get; set; }


        public double Totalprice { get; set; }



        public override void SetValuesFromObject(Booking obj)
        {
            Key = obj.Key;
            CheckInDate = obj.CheckInDate;
            CheckInTime = obj.CheckInTime;
            CheckOutTime = obj.CheckOutTime;
            CheckOutDate = obj.CheckOutDate;
            Breakfast = obj.Breakfast;
            DateOfBooking = obj.DateOfBooking;
            DateOfInvoice = obj.DateOfInvoice;
            BookingID = obj.BookingID;
            PhoneNumber = obj.PhoneNumber;
            SummerhouseName = obj.SummerhouseName;
        }
    }
}
