using Candidates.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Candidates.Core.DTO;
using Ninject;
using Candidates.Core.Repositories;
using Candidates.DAL;

namespace Candidates.BLL
{
    public class CandidateServices : ICanditateServices
    {
        private readonly ICandidateRepository candidateRepo = DALFactory.CreateCandidateRepository();
        
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
