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
    public class SommerhusTablesController : ApiController
    {
        private SommerhusDBContext db = new SommerhusDBContext();

        // GET: api/SommerhusTables
        public IQueryable<SommerhusTable> GetSommerhusTables()
        {
            return db.SommerhusTables;
        }

        // GET: api/SommerhusTables/5
        [ResponseType(typeof(SommerhusTable))]
        public IHttpActionResult GetSommerhusTable(string id)
        {
            SommerhusTable sommerhusTable = db.SommerhusTables.Find(id);
            if (sommerhusTable == null)
            {
                return NotFound();
            }

            return Ok(sommerhusTable);
        }

        // PUT: api/SommerhusTables/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSommerhusTable(string id, SommerhusTable sommerhusTable)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sommerhusTable.sommerhusNavn)
            {
                return BadRequest();
            }

            db.Entry(sommerhusTable).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SommerhusTableExists(id))
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

        // POST: api/SommerhusTables
        [ResponseType(typeof(SommerhusTable))]
        public IHttpActionResult PostSommerhusTable(SommerhusTable sommerhusTable)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SommerhusTables.Add(sommerhusTable);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (SommerhusTableExists(sommerhusTable.sommerhusNavn))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = sommerhusTable.sommerhusNavn }, sommerhusTable);
        }

        // DELETE: api/SommerhusTables/5
        [ResponseType(typeof(SommerhusTable))]
        public IHttpActionResult DeleteSommerhusTable(string id)
        {
            SommerhusTable sommerhusTable = db.SommerhusTables.Find(id);
            if (sommerhusTable == null)
            {
                return NotFound();
            }

            db.SommerhusTables.Remove(sommerhusTable);
            db.SaveChanges();

            return Ok(sommerhusTable);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SommerhusTableExists(string id)
        {
            return db.SommerhusTables.Count(e => e.sommerhusNavn == id) > 0;
        }
    }
}