using AutoMapper;
using HiringManager.DAL.Modules;
using HiringManager.DTO.CompanyModule;
using HiringManager.DTO.CountryModule;
using HiringManager.DTO.EmployeeModule;
using HiringManager.DTO.JobsModule;
using HiringManager.DTO.SkillModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiringManager.DAL.Profiles
{
    public  class MapperProfiles :Profile
    {
        public MapperProfiles()
        {
            CreateMap<Country, CoutryDTO>().ReverseMap();

            CreateMap<Job, JobDTO>().ReverseMap();

            CreateMap<Employee, EmployeeDTO>().ReverseMap();

            CreateMap<Company, CompanyDTO>().ReverseMap();

            CreateMap<Skill, SkillDTO>().ReverseMap();
        }
    }
}
