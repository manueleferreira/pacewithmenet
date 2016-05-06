using System;
using System.Linq;
using System.Web.Http;
using PaceWithMeAPI.Models;
using Tweetinvi;
using Tweetinvi.Core.Interfaces;
using System.Collections.Generic;

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
        //public IEnumerable<PaceRecord> GetAllPaceRecords()
        //{
         //   return paces;
        //}

        public IEnumerable<Tweet> GetAllPaceRecords()
        {
            var appCreds = Auth.SetApplicationOnlyCredentials(Constants.ConsumerKey, Constants.ConsumerSecret);
            Auth.InitializeApplicationOnlyCredentials(appCreds);

            var matchingTweets = Search.SearchTweets(Constants.Tags);
            return matchingTweets;

            //return paces;
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
