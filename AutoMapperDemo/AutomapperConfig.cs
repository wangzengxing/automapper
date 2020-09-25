using AutoMapper;
using AutoMapperDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperDemo
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Student, StudentViewModel>()
                .ForMember(r => r.StudentName, t => t.MapFrom(s => s.Name));
        }
    }
}
