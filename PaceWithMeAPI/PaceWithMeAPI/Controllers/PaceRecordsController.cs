using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PaceWithMeAPI.Models;

namespace PaceWithMeAPI.Controllers
{
    public class PaceRecordsController : ApiController
    {
        PaceRecord[] paces = new PaceRecord[]
        {
            new PaceRecord { Id = 1, UserName = "@manueleferreira", Text = "legal #pace #run" }
        };

        /// <summary>
        /// list all pace records
        /// </summary>
        /// <returns></returns>
        public IEnumerable<PaceRecord> GetAllPaceRecords()
        {
            return paces;
        }

        public IHttpActionResult GetPaceRecord(int id)
        {
            var pace = paces.FirstOrDefault((p) => p.Id == id);
            if(pace == null)
            {
                return NotFound();
            }

            return Ok(pace);
        }
    }
}
