using Application.Features.Student.Commands;
using Application.Features.Student.DTOs;
using Application.Interface;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public async Task<List<Domain.Student>> GetAll()
        {
            var sql = $"select * from Student";
            using (var connection = new SqlConnection("Data Source=.;Initial Catalog=Amiraan;Integrated Security=True"))
            {
                connection.Open();
                var result = await connection.QueryAsync<Domain.Student>(sql, commandType: System.Data.CommandType.Text);
                return result.ToList();
            }
        }
    }
}
