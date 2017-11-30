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
    public class LeverandørController : ApiController
    {
        private SommerhusDBContext db = new SommerhusDBContext();

        // GET: api/Leverandør
        public IQueryable<Leverandør> GetLeverandør()
        {
            return db.Leverandør;
        }

        // GET: api/Leverandør/5
        [ResponseType(typeof(Leverandør))]
        public IHttpActionResult GetLeverandør(int id)
        {
            Leverandør leverandør = db.Leverandør.Find(id);
            if (leverandør == null)
            {
                return NotFound();
            }

            return Ok(leverandør);
        }

        // PUT: api/Leverandør/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLeverandør(int id, Leverandør leverandør)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != leverandør.CVR)
            {
                return BadRequest();
            }

            db.Entry(leverandør).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LeverandørExists(id))
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

        // POST: api/Leverandør
        [ResponseType(typeof(Leverandør))]
        public IHttpActionResult PostLeverandør(Leverandør leverandør)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Leverandør.Add(leverandør);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (LeverandørExists(leverandør.CVR))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = leverandør.CVR }, leverandør);
        }

        // DELETE: api/Leverandør/5
        [ResponseType(typeof(Leverandør))]
        public IHttpActionResult DeleteLeverandør(int id)
        {
            Leverandør leverandør = db.Leverandør.Find(id);
            if (leverandør == null)
            {
                return NotFound();
            }

            db.Leverandør.Remove(leverandør);
            db.SaveChanges();

            return Ok(leverandør);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LeverandørExists(int id)
        {
            return db.Leverandør.Count(e => e.CVR == id) > 0;
        }
    }
}