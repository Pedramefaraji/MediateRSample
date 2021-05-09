using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Features.Student.Commands;
using FluentValidation;

namespace Application.Features.Student.Validators
{
    public class RegisterStudentValidator : AbstractValidator <RegisterStudent>
    {
        public RegisterStudentValidator()
        {
            RuleFor(x => x.id).NotEmpty().WithMessage("مقدار id نمیتواند خالی باشد");
        }
    }
}
