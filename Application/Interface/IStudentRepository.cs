using Application.Features.Student.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IStudentRepository
    {
        Task<int> CreateStudent(RegisterStudent student);
        Task<bool> DeleteStudent(int Id);
    }
}
