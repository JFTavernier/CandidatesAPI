using ReedUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Candidates.Core.APIContract;
using Candidates.Core.DTO;

namespace ReedUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public PartialViewResult GetCandidates()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:2690");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync("api/Candidates").Result;
                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    MatchCandidates model = JsonConvert.DeserializeObject<MatchCandidates>(json);
                    ListCandidatesViewModels vm = new ListCandidatesViewModels() { Candidates = model.Matches };
                    return PartialView("_ListCandidates",vm);
                }
                else
                {
                    return PartialView("_ListCandidates", null);
                }
            }
        }

        [HttpPost]
        public PartialViewResult GetCandidateDetails(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:2690");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync("api/Candidates/"+ id).Result;
                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    CandidateDetailsDTO model = JsonConvert.DeserializeObject<CandidateDetailsDTO>(json);
                    return PartialView("_CandidateDetails", model);
                }
                else
                {
                    return PartialView("_CandidateDetails", null);
                }
            }
        }


    }
}