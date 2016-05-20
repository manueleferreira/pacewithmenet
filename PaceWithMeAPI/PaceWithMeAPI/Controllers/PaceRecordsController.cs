using System;
using System.Linq;
using System.Web.Http;
using PaceWithMeAPI.Models;
using Tweetinvi;
using Tweetinvi.Json;
using Tweetinvi.Core;
using Tweetinvi.Core.Interfaces;
using Tweetinvi.Core.Enum;
using Tweetinvi.Core.Extensions;
using Tweetinvi.Core.Interfaces.Controllers;
using Tweetinvi.Core.Interfaces.DTO;
using Tweetinvi.Core.Interfaces.Models;
using Tweetinvi.Core.Parameters;
using System.Collections.Generic;

namespace PaceWithMeAPI.Controllers
{
    public class PaceRecordsController : ApiController
    {
        /// <summary>
        /// list all pace records
        /// </summary>
        /// <returns></returns>
        //public IEnumerable<PaceRecord> GetAllPaceRecords()
        //{
         //   return paces;
        //}

        public IEnumerable<PaceRecord> GetAllPaceRecords()
        {
            var appCreds = Auth.SetApplicationOnlyCredentials(Constants.ConsumerKey, Constants.ConsumerSecret);
            Auth.InitializeApplicationOnlyCredentials(appCreds);

            var searchParameter = new TweetSearchParameters(Constants.Tags)
            {
                MaximumNumberOfResults = 10
            };
            
            var matchingTweets = Search.SearchTweets(searchParameter);

            List<PaceRecord> paceRecordList = new List<PaceRecord>();
            foreach ( var tweet in matchingTweets )
            {
                PaceRecord pace = new PaceRecord
                {
                    Id = tweet.Id,
                    UserName = tweet.CreatedBy.ScreenName,
                    Text = tweet.Text,
                };

                paceRecordList.Add(pace);
            }

            return paceRecordList;
        }

        //        public IHttpActionResult GetPaceRecord(int id)
        //        {
        //            var pace = paces.FirstOrDefault((p) => p.Id == id);
        //            if(pace == null)
        //            {
        //                return NotFound();
        //}
        //
        //        return Ok(pace);
        //}
    }
}
