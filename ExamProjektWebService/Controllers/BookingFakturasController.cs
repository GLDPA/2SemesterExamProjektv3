using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ExamProjektWebService;

namespace ExamProjektWebService.Controllers
{
    public class BookingFakturasController : ApiController
    {
        private SommerhusExamDBContext db = new SommerhusExamDBContext();

        // GET: api/BookingFakturas
        public IQueryable<BookingFaktura> GetBookingFakturas()
        {
            return db.BookingFakturas;
        }

        // GET: api/BookingFakturas/5
        [ResponseType(typeof(BookingFaktura))]
        public IHttpActionResult GetBookingFaktura(int id)
        {
            BookingFaktura bookingFaktura = db.BookingFakturas.Find(id);
            if (bookingFaktura == null)
            {
                return NotFound();
            }

            return Ok(bookingFaktura);
        }

        // PUT: api/BookingFakturas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBookingFaktura(int id, BookingFaktura bookingFaktura)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bookingFaktura.bookingNummer)
            {
                return BadRequest();
            }

            db.Entry(bookingFaktura).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookingFakturaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/BookingFakturas
        [ResponseType(typeof(BookingFaktura))]
        public IHttpActionResult PostBookingFaktura(BookingFaktura bookingFaktura)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.BookingFakturas.Add(bookingFaktura);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (BookingFakturaExists(bookingFaktura.bookingNummer))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = bookingFaktura.bookingNummer }, bookingFaktura);
        }

        // DELETE: api/BookingFakturas/5
        [ResponseType(typeof(BookingFaktura))]
        public IHttpActionResult DeleteBookingFaktura(int id)
        {
            BookingFaktura bookingFaktura = db.BookingFakturas.Find(id);
            if (bookingFaktura == null)
            {
                return NotFound();
            }

            db.BookingFakturas.Remove(bookingFaktura);
            db.SaveChanges();

            return Ok(bookingFaktura);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BookingFakturaExists(int id)
        {
            return db.BookingFakturas.Count(e => e.bookingNummer == id) > 0;
        }
    }
}