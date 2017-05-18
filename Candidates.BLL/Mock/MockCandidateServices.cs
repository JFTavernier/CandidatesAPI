using Candidates.Core.DTO;
using Candidates.Core.Repositories;
using Candidates.Core.Services;
using Candidates.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates.BLL.Mock
{
    public class MockCandidateServices : ICanditateServices
    {
        private readonly ICandidateRepository candidateRepo = DALFactory.MockCandidateRepository();

        public IEnumerable<CandidateDTO> GetAllCandidates()
        {
            return candidateRepo.GetAllCandidates();
        }

        public CandidateDetailsDTO GetCandidateDetails(int Id)
        {
            return candidateRepo.GetCandidateDetails(Id);
        }
    }
}
