using System.Collections.Generic;
namespace Candidates.Core.DTO
{
    public class CandidateDetailsDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Salary { get; set; }

        public string MostRecentEmployment { get; set; }

        public double? MostRecentEmploymentDurationInYears { get; set; }

        public string CurrentLocation { get; set; }

        public List<string> Skills { get; set; }
    }
}