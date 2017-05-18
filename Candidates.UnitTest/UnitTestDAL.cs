using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Candidates.DAL;
using Candidates.Core.Repositories;
using System.Collections.Generic;
using System.Collections;
using Candidates.Core.DTO;
using System.Linq;
using Candidates.DAL.Entities;

namespace Candidates.UnitTest
{
    //Don't Forget To Create the Database, Change the ConnectionString, And UnMock the DAL in CandidatesController before launching the test
    [TestClass]
    public class UnitTestDAL
    {
        [TestMethod]
        public void CanAccessDatabase()
        {
            using (var ctx = new CandidatesDBContext())
            {
                Skill skill = new Skill("test");
                ctx.Skills.Add(skill);
                ctx.SaveChanges();
                ctx.Skills.Remove(skill);
                ctx.SaveChanges();
            }
        }

        [TestMethod]
        public void GetAllCandidatesIsNotNullOrEmpty()
        {
            ICandidateRepository repo = DALFactory.CreateCandidateRepository();
            List<CandidateDTO> candidates = repo.GetAllCandidates().ToList();

            Assert.AreNotEqual(candidates, null);
            Assert.AreNotEqual(candidates.Count, 0);
        }

        [TestMethod]
        public void GetDetailsCandidateIsWorking()
        {
            ICandidateRepository repo = DALFactory.CreateCandidateRepository();
            int Id = repo.GetAllCandidates().Where(c => c.Name == "Sherlock Holmes").First().Id;

            CandidateDetailsDTO candidateDetails = repo.GetCandidateDetails(Id);
            Assert.AreEqual(candidateDetails.Name, "Sherlock Holmes");
            Assert.AreEqual(candidateDetails.Skills.Contains("Deduction"), true);
        }
    }
}
