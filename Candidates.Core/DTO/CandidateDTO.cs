using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates.Core.DTO
{
    public class CandidateDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Salary { get; set; }

        public string MostRecentEmployment { get; set; }

        public double? MostRecentEmploymentDurationInYears { get; set; }

        public string CurrentLocation { get; set; }

    }
}
