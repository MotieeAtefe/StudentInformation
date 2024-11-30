using Microsoft.AspNetCore.Http;
using StudentInformation.Model;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
namespace StudentInformation.Data
{
    public class ADOStudentRepository: IStudentRepository
    {
        private readonly string _connectionString;
        public ADOStudentRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public void AddStudent(Student student)
        {
            using (SqlConnection connection = new SqlConnection(
                _connectionString))
            {
                using (var command = new SqlCommand("sp_AddStudent", connection))
                {
                    command.CommandType = CommandType.StoredProcedure; 
                    command.Parameters.AddWithValue("@Name",student.Name);
                    command.Parameters.AddWithValue("@Email", student.Email); 
                    command.Parameters.AddWithValue("@Age", student.Age);   
                    connection.Open();
                    command.ExecuteNonQuery();

                }

                  
            }
        }
        public IEnumerable<Student> GetAllStudents() 
        { 
            var student = new List<Student>();
            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand(""))
            }
        }
       
    }
}
