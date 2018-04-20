using Candidates.BLL;
using Candidates.Core.APIContract;
using Candidates.Core.DTO;
using Candidates.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ReedAPI.Controllers
{
    public class CandidatesController : ApiController
    {
        //Use the factory to Mock the candidateServices 
        private readonly ICanditateServices candidatesServices = BLLFactory.MockCandidateServices();

        [HttpGet]
        public IHttpActionResult GetAllCandidates()
        {
            MatchCandidates result = new MatchCandidates();
            result.Matches = candidatesServices.GetAllCandidates().ToList();
            result.NumberOfMatches = result.Matches.Count();

            return Ok(result);
        }

        public IHttpActionResult GetCandidateDetails(int id)
        {
            return Ok(candidatesServices.GetCandidateDetails(id));
        }
    }
}
