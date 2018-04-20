using AutoMapper;
using Candidates.Core.DTO;
using Candidates.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates.DAL.Mapping
{
    public static class MapperConfig
    {
        private static MapperConfiguration MapperDALConfig;

        public static IMapper MapperDAL;

        public static void InitMapper()
        {
            MapperDALConfig = new MapperConfiguration(
                cf =>
                {
                    cf.CreateMap<Candidate, CandidateDTO>();
                    cf.CreateMap<Candidate, CandidateDetailsDTO>();
                    cf.CreateMap<CandidateDetailsDTO, Candidate>();
                    cf.CreateMap<CandidateDTO, Candidate>();
                    cf.CreateMap<Skill, SkillDTO>();
                });
            MapperDAL = MapperDALConfig.CreateMapper();
        }

    }
}
