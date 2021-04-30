using Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class UnitOfWork : IUintOfWork
    {
        public UnitOfWork(IStudentRepository studentRepository)
        {
            _StudentRepository = studentRepository;
        }
        public IStudentRepository _StudentRepository { get; }

    }
}
