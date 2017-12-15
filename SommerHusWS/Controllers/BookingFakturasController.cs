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
using SommerHusWS;

namespace SommerHusWS.Controllers
{
    public class BookingFakturasController : ApiController
    {
        private SommerhusDBContext db = new SommerhusDBContext();

        // GET: api/BookingFakturas
        public IQueryable<BookingFaktura> GetBookingFakturas()
        {
            return db.BookingFakturas;
        }

        // GET: api/BookingFakturas/5
        [ResponseType(typeof(BookingFaktura))]
        public IHttpActionResult GetBookingFaktura(string id)
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
        public IHttpActionResult PutBookingFaktura(string id, BookingFaktura bookingFaktura)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bookingFaktura.Email)
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
                if (BookingFakturaExists(bookingFaktura.Email))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = bookingFaktura.Email }, bookingFaktura);
        }

        // DELETE: api/BookingFakturas/5
        [ResponseType(typeof(BookingFaktura))]
        public IHttpActionResult DeleteBookingFaktura(string id)
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

        private bool BookingFakturaExists(string id)
        {
            return db.BookingFakturas.Count(e => e.Email == id) > 0;
        }
    }
}