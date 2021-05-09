using Application.Features.Student.DTOs;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Student.MappingProfiles
{
    public class StudentMappingProfile : Profile
    {
        public StudentMappingProfile()
        {
            CreateMap<Domain.Student, GetAllStudentDTO>();
            //CreateMap<Domain.Student, GetAllStudentDTO>().ForMember(d => d.FullName,
            //d => d.MapFrom(x => $"{x.Name} {x.LName}"));
        }
    }
}
