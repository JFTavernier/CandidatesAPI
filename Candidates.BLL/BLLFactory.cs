using Candidates.BLL.Mock;
using Candidates.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates.BLL
{
    public static class BLLFactory
    {
        public static ICanditateServices CreateCandidateServices()
        {
            return new CandidateServices();
        }

        public static ICanditateServices MockCandidateServices()
        {
            return new MockCandidateServices();
        }
     }
}
