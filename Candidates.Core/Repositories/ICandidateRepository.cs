using Candidates.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates.Core.Repositories
{
    public interface ICandidateRepository
    {
         IEnumerable<CandidateDTO> GetAllCandidates();

         CandidateDetailsDTO GetCandidateDetails(int Id);
    }
}
