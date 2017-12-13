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
using SommerhusProjektWebService;

namespace SommerhusProjektWebService.Controllers
{
    public class KontaktPersonsController : ApiController
    {
        private SommerhusDBContext db = new SommerhusDBContext();

        // GET: api/KontaktPersons
        public IQueryable<KontaktPerson> GetKontaktPersons()
        {
            return db.KontaktPersons;
        }

        // GET: api/KontaktPersons/5
        [ResponseType(typeof(KontaktPerson))]
        public IHttpActionResult GetKontaktPerson(int id)
        {
            KontaktPerson kontaktPerson = db.KontaktPersons.Find(id);
            if (kontaktPerson == null)
            {
                return NotFound();
            }

            return Ok(kontaktPerson);
        }

        // PUT: api/KontaktPersons/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKontaktPerson(int id, KontaktPerson kontaktPerson)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != kontaktPerson.IDNummer)
            {
                return BadRequest();
            }

            db.Entry(kontaktPerson).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KontaktPersonExists(id))
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

        // POST: api/KontaktPersons
        [ResponseType(typeof(KontaktPerson))]
        public IHttpActionResult PostKontaktPerson(KontaktPerson kontaktPerson)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.KontaktPersons.Add(kontaktPerson);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (KontaktPersonExists(kontaktPerson.IDNummer))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = kontaktPerson.IDNummer }, kontaktPerson);
        }

        // DELETE: api/KontaktPersons/5
        [ResponseType(typeof(KontaktPerson))]
        public IHttpActionResult DeleteKontaktPerson(int id)
        {
            KontaktPerson kontaktPerson = db.KontaktPersons.Find(id);
            if (kontaktPerson == null)
            {
                return NotFound();
            }

            db.KontaktPersons.Remove(kontaktPerson);
            db.SaveChanges();

            return Ok(kontaktPerson);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KontaktPersonExists(int id)
        {
            return db.KontaktPersons.Count(e => e.IDNummer == id) > 0;
        }
    }
}