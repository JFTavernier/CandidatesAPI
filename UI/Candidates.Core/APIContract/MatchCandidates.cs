using Candidates.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates.Core.APIContract
{
    public class MatchCandidates
    {
        public int NumberOfMatches { get; set; }

        public List<CandidateDTO> Matches { get; set; }
    }
}
