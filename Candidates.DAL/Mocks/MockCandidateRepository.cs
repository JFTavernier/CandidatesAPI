using Candidates.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Candidates.Core.DTO;

namespace Candidates.DAL.Mocks
{
    internal class MockCandidateRepository : ICandidateRepository
    {
        public IEnumerable<CandidateDTO> GetAllCandidates()
        {
            return new List<CandidateDTO>()
                 {
                 new CandidateDTO() {
                    Id=100000,
                    Name="Sherlock Holmes",
                    Salary="\u0026pound 60,000 p.a.",
                    MostRecentEmployment="Strategy Consultant",
                    MostRecentEmploymentDurationInYears= 2.5,
                    CurrentLocation= "London, N2",
                 },
                 new CandidateDTO(){
                    Id=100001,
                    Name="Ian Blake",
                    Salary="\u0026pound 35,000 p.a.",
                    MostRecentEmployment="Senior pricing manager",
                    MostRecentEmploymentDurationInYears= 1.5,
                    CurrentLocation= "London, E11",
                },
                new CandidateDTO(){
                    Id=100010,
                    Name="Kelly Clarkson",
                    Salary="Not specified",
                    MostRecentEmployment="Pricing Analyst",
                    MostRecentEmploymentDurationInYears= null,
                    CurrentLocation= "London, WC3",
                },
                new CandidateDTO() {
                    Id=100011,
                    Name="Ashley Troops",
                    Salary="\u0026pound 66,000 p.a.",
                    MostRecentEmployment="Pricing Expert",
                    MostRecentEmploymentDurationInYears= 5,
                    CurrentLocation= "Not specified",
                },
                new CandidateDTO() {
                    Id=100100,
                    Name="Billy Jones",
                    Salary="\u0026pound 29,000 p.a.",
                    MostRecentEmployment="Pricing Expert",
                    MostRecentEmploymentDurationInYears= 2,
                    CurrentLocation= "London SE4",
                },
                new CandidateDTO(){
                    Id=100101,
                    Name="Diego Costa",
                    Salary="\u0026pound 58,000 p.a.",
                    MostRecentEmployment="Not specified",
                    MostRecentEmploymentDurationInYears= null,
                    CurrentLocation= "London SW2",
                },
                new CandidateDTO(){
                    Id=100110,
                    Name="Jennifer Smith",
                    Salary="\u0026pound 44,000 p.a.",
                    MostRecentEmployment="Senior pricing expert",
                    MostRecentEmploymentDurationInYears= 1.5,
                    CurrentLocation= "London EC2",
                },
                new CandidateDTO(){
                    Id=100111,
                    Name="Allistair Smith",
                    Salary="\u0026pound 38,000 p.a.",
                    MostRecentEmployment="Pricing consultant",
                    MostRecentEmploymentDurationInYears= 0.5,
                    CurrentLocation= "London E8",
                },
                new CandidateDTO(){
                    Id=101000,
                    Name="James Patelidis",
                    Salary="\u0026pound 25,000 p.a.",
                    MostRecentEmployment="Junior pricing advisor",
                    MostRecentEmploymentDurationInYears= 1.5,
                    CurrentLocation= "Not specified",
                },
                new CandidateDTO(){
                    Id=101001,
                    Name="Johnie Walker",
                    Salary="\u0026pound 30,000 p.a.",
                    MostRecentEmployment="Senior Accountanct",
                    MostRecentEmploymentDurationInYears= 45,
                    CurrentLocation= "London N8",
                }
            };
        }
        public CandidateDetailsDTO GetCandidateDetails(int Id)
        {
            switch (Id)
            {
                case 100000:
                    return new CandidateDetailsDTO()
                    {
                        Id = 100000,
                        Name = "Sherlock Holmes",
                        Salary = "\u0026pound 60,000 p.a.",
                        MostRecentEmployment = "Strategy Consultant",
                        MostRecentEmploymentDurationInYears = 2.5,
                        CurrentLocation = "London, N2",
                        Skills = new List<string>() { "Deduction", "Observation", "Investigation", "Intuition", "Hat wearing" }
                    };
                case 100001:
                    return new CandidateDetailsDTO()
                    {
                        Id = 100001,
                        Name = "Ian Blake",
                        Salary = "\u0026pound 35,000 p.a.",
                        MostRecentEmployment = "Senior pricing manager",
                        MostRecentEmploymentDurationInYears = 1.5,
                        CurrentLocation = "London, E11",
                        Skills = new List<string>() { "MS Office", "Visual Studio", "Maths", "Accountancy", "Dog grooming" }
                    };
                case 100010:
                    return new CandidateDetailsDTO()
                    {
                        Id = 100010,
                        Name = "Kelly Clarkson",
                        Salary = "Not specified",
                        MostRecentEmployment = "Pricing Analyst",
                        MostRecentEmploymentDurationInYears = null,
                        CurrentLocation = "London, WC3",
                        Skills = new List<string>() { "Pricing", "Analysis", "Hang gliding" }
                    };
                case 100011:
                    return new CandidateDetailsDTO()
                    {
                        Id = 100011,
                        Name = "Ashley Troops",
                        Salary = "\u0026pound 66,000 p.a.",
                        MostRecentEmployment = "Pricing Expert",
                        MostRecentEmploymentDurationInYears = 5,
                        CurrentLocation = "Not specified",
                        Skills = new List<string>() { "Pricing", "Statistical Analysis", "Linear Algebra", "Advanced scuba-diving" }
                    };
                 case 100100:
                    return new CandidateDetailsDTO()
                    {
                        Id = 100100,
                        Name = "Billy Jones",
                        Salary = "\u0026pound 29,000 p.a.",
                        MostRecentEmployment = "Pricing Expert",
                        MostRecentEmploymentDurationInYears = 2,
                        CurrentLocation = "London SE4",
                        Skills = new List<string>() { "MS Word", "Hiking" }
                    };
                 case 100101:
                    return new CandidateDetailsDTO()
                    {
                        Id = 100101,
                        Name = "Diego Costa",
                        Salary = "\u0026pound 58,000 p.a.",
                        MostRecentEmployment = "Not specified",
                        MostRecentEmploymentDurationInYears = null,
                        CurrentLocation = "London SW2",
                        Skills = new List<string>() { "Linux", "SQL", "C#", "Visual Studio" }
                    };
                 case 100110:
                    return new CandidateDetailsDTO()
                    {
                        Id = 100110,
                        Name = "Jennifer Smith",
                        Salary = "\u0026pound 44,000 p.a.",
                        MostRecentEmployment = "Senior pricing expert",
                        MostRecentEmploymentDurationInYears = 1.5,
                        CurrentLocation = "London EC2",
                        Skills = new List<string>() { "Consultancy", "Accountancy", "MS Calculator" }
                    };
                 case 100111:
                    return new CandidateDetailsDTO()
                    {
                        Id = 100111,
                        Name = "Allistair Smith",
                        Salary = "\u0026pound 38,000 p.a.",
                        MostRecentEmployment = "Pricing consultant",
                        MostRecentEmploymentDurationInYears = 0.5,
                        CurrentLocation = "London E8",
                        Skills = new List<string>() { "Differencial Equations", "Maths modeling", "Finance", "Skiing" }
                    };
                 case 101000:
                    return new CandidateDetailsDTO()
                    {
                        Id = 101000,
                        Name = "James Patelidis",
                        Salary = "\u0026pound 25,000 p.a.",
                        MostRecentEmployment = "Junior pricing advisor",
                        MostRecentEmploymentDurationInYears = 1.5,
                        CurrentLocation = "Not specified",
                        Skills = new List<string>() { "Advanced Maths", "Calculus", "Dancing" }
                    };
                case 101001:
                    return new CandidateDetailsDTO()
                    {
                        Id = 101001,
                        Name = "Johnie Walker",
                        Salary = "\u0026pound 30,000 p.a.",
                        MostRecentEmployment = "Senior Accountanct",
                        MostRecentEmploymentDurationInYears = 45,
                        CurrentLocation = "London N8",
                        Skills = new List<string>() { "Accountancy", "AAT", "Skydiving" }
                    };
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
