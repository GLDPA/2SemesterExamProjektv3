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
    public class LeverancesController : ApiController
    {
        private SommerhusExamDBContext db = new SommerhusExamDBContext();

        // GET: api/Leverances
        public IQueryable<Leverance> GetLeverances()
        {
            return db.Leverances;
        }

        // GET: api/Leverances/5
        [ResponseType(typeof(Leverance))]
        public IHttpActionResult GetLeverance(int id)
        {
            Leverance leverance = db.Leverances.Find(id);
            if (leverance == null)
            {
                return NotFound();
            }

            return Ok(leverance);
        }

        // PUT: api/Leverances/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLeverance(int id, Leverance leverance)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != leverance.BestillingsNr)
            {
                return BadRequest();
            }

            db.Entry(leverance).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LeveranceExists(id))
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

        // POST: api/Leverances
        [ResponseType(typeof(Leverance))]
        public IHttpActionResult PostLeverance(Leverance leverance)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Leverances.Add(leverance);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (LeveranceExists(leverance.BestillingsNr))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = leverance.BestillingsNr }, leverance);
        }

        // DELETE: api/Leverances/5
        [ResponseType(typeof(Leverance))]
        public IHttpActionResult DeleteLeverance(int id)
        {
            Leverance leverance = db.Leverances.Find(id);
            if (leverance == null)
            {
                return NotFound();
            }

            db.Leverances.Remove(leverance);
            db.SaveChanges();

            return Ok(leverance);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LeveranceExists(int id)
        {
            return db.Leverances.Count(e => e.BestillingsNr == id) > 0;
        }
    }
}