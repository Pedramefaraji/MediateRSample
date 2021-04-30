using Application.Features.Student.Commands;
using Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class StudentRepository : IStudentRepository
    {
        public async Task<int> CreateStudent(RegisterStudent student)
        {
            return 1;
        }
        public async Task<bool> DeleteStudent(int Id)
        {
            throw new NotImplementedException();
        }

    }
}
