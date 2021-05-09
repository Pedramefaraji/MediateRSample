using Application.Features.Student.DTOs;
using Application.Features.Student.Queries;
using Application.Interface;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Student.Handlers
{
    public class GetAllStudentQueryHandler : IRequestHandler<GetAllStudentQuery, List<DTOs.GetAllStudentDTO>>
    {
        private readonly IUintOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllStudentQueryHandler(IUintOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<GetAllStudentDTO>> Handle(GetAllStudentQuery request, CancellationToken cancellationToken)
        {

            var x = _mapper.Map<List<GetAllStudentDTO>>(await _unitOfWork._StudentRepository.GetAll());
            var x1 = _unitOfWork._StudentRepository.GetAll();
            var y = _mapper.Map<GetAllStudentDTO>(x1.Result.FirstOrDefault());
            return x;
        }
    }
}
