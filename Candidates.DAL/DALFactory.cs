using Candidates.Core.Repositories;
using Candidates.DAL.Mocks;
using Candidates.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates.DAL
{
    public static class DALFactory
    {
        public static ICandidateRepository CreateCandidateRepository()
        {
            return new CandidateRepository();
        }

        public static ICandidateRepository MockCandidateRepository()
        {
            return new MockCandidateRepository();
        }
    }
}
