using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates.DAL.Entities
{
    public class Skill
    {
        public Skill()
        { }

        public Skill(string Name)
        {
            this.Name = Name;
        }

        public Skill(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
            this.Candidates = new HashSet<Candidate>();
        }

        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Candidate> Candidates { get; set; }

        public override string ToString()
        {
            return this.Name;
        }

    }
}
