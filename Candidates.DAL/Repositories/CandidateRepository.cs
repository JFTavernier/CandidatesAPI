using Candidates.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Candidates.Core.DTO;
using Candidates.DAL.Mapping;
using Ninject;

namespace Candidates.DAL.Repositories
{
    internal class CandidateRepository : ICandidateRepository
    {
        public CandidateRepository()
        {
            MapperConfig.InitMapper();
        }

        public IEnumerable<CandidateDTO> GetAllCandidates()
        {
            using (CandidatesDBContext context = new CandidatesDBContext())
            {
                IEnumerable<Candidate> candidates = context.Candidates;
                return MapperConfig.MapperDAL.Map<IEnumerable<CandidateDTO>>(candidates);
            }
        }

        public CandidateDetailsDTO GetCandidateDetails(int Id)
        {
            using (CandidatesDBContext context = new CandidatesDBContext())
            {
                Candidate candidate = context.Candidates.Include("Skills").Single(c => c.Id == Id);
                return MapperConfig.MapperDAL.Map<CandidateDetailsDTO>(candidate);
            }
        }
    }
}
