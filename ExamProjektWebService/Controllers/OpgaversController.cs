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
    public class OpgaversController : ApiController
    {
        private SommerhusExamDBContext db = new SommerhusExamDBContext();

        // GET: api/Opgavers
        public IQueryable<Opgaver> GetOpgavers()
        {
            return db.Opgavers;
        }

        // GET: api/Opgavers/5
        [ResponseType(typeof(Opgaver))]
        public IHttpActionResult GetOpgaver(int id)
        {
            Opgaver opgaver = db.Opgavers.Find(id);
            if (opgaver == null)
            {
                return NotFound();
            }

            return Ok(opgaver);
        }

        // PUT: api/Opgavers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOpgaver(int id, Opgaver opgaver)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != opgaver.ArbejdsId)
            {
                return BadRequest();
            }

            db.Entry(opgaver).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OpgaverExists(id))
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

        // POST: api/Opgavers
        [ResponseType(typeof(Opgaver))]
        public IHttpActionResult PostOpgaver(Opgaver opgaver)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Opgavers.Add(opgaver);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (OpgaverExists(opgaver.ArbejdsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = opgaver.ArbejdsId }, opgaver);
        }

        // DELETE: api/Opgavers/5
        [ResponseType(typeof(Opgaver))]
        public IHttpActionResult DeleteOpgaver(int id)
        {
            Opgaver opgaver = db.Opgavers.Find(id);
            if (opgaver == null)
            {
                return NotFound();
            }

            db.Opgavers.Remove(opgaver);
            db.SaveChanges();

            return Ok(opgaver);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OpgaverExists(int id)
        {
            return db.Opgavers.Count(e => e.ArbejdsId == id) > 0;
        }
    }
}