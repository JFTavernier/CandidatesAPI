using Candidates.Core.DTO;
using Candidates.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates.DAL
{
    public class Candidate
    {
        public Candidate()
        {
            this.Skills = new HashSet<Skill>();
        }

        [Key]
        public int Id { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Salary { get; set; }

        [StringLength(50)]
        public string MostRecentEmployment { get; set; }

        public double? MostRecentEmploymentDurationInYears { get; set; }

        [StringLength(50)]
        public string CurrentLocation { get; set; }

        public virtual ICollection<Skill> Skills { get; set; }


    }
}
