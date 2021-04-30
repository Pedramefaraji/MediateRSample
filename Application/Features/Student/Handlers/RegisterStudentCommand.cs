using Application.Features.Student.Commands;
using Application.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Student.Command.Handlers
{

    public class RegisterStudentCommandHandler : IRequestHandler<Application.Features.Student.Commands.RegisterStudent, int>
    {
        private readonly IUintOfWork _unitOfWork;
        public RegisterStudentCommandHandler(IUintOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<int> Handle(Application.Features.Student.Commands.RegisterStudent request, CancellationToken cancellationToken)
        {
            var z = await _unitOfWork._StudentRepository.CreateStudent(request);
            return z;
        }
    }
}